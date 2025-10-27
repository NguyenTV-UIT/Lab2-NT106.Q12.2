using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2_LTMCB
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btn_rdfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                if (ofd.FileName == "")
                    throw new Exception("Chưa chọn file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                if (ofd.FileName.Substring(ofd.FileName.Length - 4) != ".txt")
                    throw new Exception("Chỉ được chọn file .txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadToEnd();
            rtb_in.Text = line;
            sr.Close();
            fs.Close();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            rtb_calc.Clear();

            var lines = rtb_in.Lines;
            if (lines == null || lines.Length == 0)
                return;

            foreach (var raw in lines)
            {
                string expr = raw.Trim();
                if (string.IsNullOrEmpty(expr))
                    continue;

                try
                {
                    var tokens = TokenHoa(expr);
                    var rpn = ChuyenDoiRPN(tokens);
                    double result = TinhToanRPN(rpn);
                    rtb_calc.AppendText($"{expr} = {result}{Environment.NewLine}");
                }
                catch (Exception ex)
                {
                    rtb_calc.AppendText($"{expr} -> Lỗi: {ex.Message}{Environment.NewLine}");
                }
            }
        }

        private List<string> TokenHoa(string s)
        {
            var tokens = new List<string>();
            var number = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (char.IsDigit(c) || c == '.')
                {
                    number.Append(c);
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/' || c == '(' || c == ')')
                {
                    if (number.Length > 0)
                    {
                        tokens.Add(number.ToString());
                        number.Clear();
                    }

                    if (c == '-')
                    {
                        bool isUnary = tokens.Count == 0
                            || tokens.Last() == "("
                            || KiemTraToanTu(tokens.Last());
                        if (isUnary)
                        {
                            tokens.Add("u-");
                            continue;
                        }
                    }

                    tokens.Add(c.ToString());
                }
                else if (char.IsWhiteSpace(c))
                {
                    if (number.Length > 0)
                    {
                        tokens.Add(number.ToString());
                        number.Clear();
                    }
                }
                else
                {
                    throw new Exception($"Ký tự '{c}' không hợp lệ.");
                }
            }

            if (number.Length > 0)
                tokens.Add(number.ToString());

            return tokens;
        }

        private bool KiemTraToanTu(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/" || token == "u-";
        }

        private List<string> ChuyenDoiRPN(List<string> tokens)
        {
            var output = new List<string>();
            var ops = new Stack<string>();

            int Precedence(string op) => op switch
            {
                "u-" => 4,
                "*" or "/" => 3,
                "+" or "-" => 2,
                _ => 0
            };

            bool IsRightAssociative(string op) => op == "u-";

            foreach (var token in tokens)
            {
                if (double.TryParse(token, NumberStyles.Number, CultureInfo.InvariantCulture, out _))
                {
                    output.Add(token);
                }
                else if (KiemTraToanTu(token))
                {
                    while (ops.Count > 0 && KiemTraToanTu(ops.Peek()))
                    {
                        var top = ops.Peek();
                        if ((IsRightAssociative(token) && Precedence(token) < Precedence(top)) ||
                            (!IsRightAssociative(token) && Precedence(token) <= Precedence(top)))
                        {
                            output.Add(ops.Pop());
                        }
                        else break;
                    }
                    ops.Push(token);
                }
                else if (token == "(")
                {
                    ops.Push(token);
                }
                else if (token == ")")
                {
                    bool foundLeftParen = false;
                    while (ops.Count > 0)
                    {
                        var op = ops.Pop();
                        if (op == "(")
                        {
                            foundLeftParen = true;
                            break;
                        }
                        output.Add(op);
                    }
                    if (!foundLeftParen)
                        throw new Exception("Dấu ngoặc không khớp.");
                }
                else
                {
                    throw new Exception($"Token không hợp lệ: {token}");
                }
            }

            while (ops.Count > 0)
            {
                var op = ops.Pop();
                if (op == "(" || op == ")")
                    throw new Exception("Dấu ngoặc không khớp.");
                output.Add(op);
            }

            return output;
        }

        private double TinhToanRPN(List<string> rpn)
        {
            var stack = new Stack<double>();
            foreach (var token in rpn)
            {
                if (double.TryParse(token, NumberStyles.Number, CultureInfo.InvariantCulture, out double n))
                {
                    stack.Push(n);
                }
                else if (token == "u-")
                {
                    if (stack.Count < 1) throw new Exception("Unary '-' thiếu toán hạng.");
                    double v = stack.Pop();
                    stack.Push(-v);
                }
                else if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    if (stack.Count < 2) throw new Exception("Thiếu toán hạng cho toán tử nhị phân.");
                    double b = stack.Pop();
                    double a = stack.Pop();
                    double res = token switch
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "*" => a * b,
                        "/" => b == 0 ? throw new Exception("Chia cho 0.") : a / b,
                        _ => throw new Exception("Toán tử không hỗ trợ.")
                    };
                    stack.Push(res);
                }
                else
                {
                    throw new Exception($"Token RPN không hợp lệ: {token}");
                }
            }

            if (stack.Count != 1)
            {
                throw new Exception("Cú pháp biểu thức không hợp lệ.");
            }    

            return stack.Pop();
        }

        private void btn_wrfile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output3.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(rtb_calc.Text);
            rtb_out.Text = rtb_calc.Text;
            sw.Close();
            fs.Close();
        }
    }
}
