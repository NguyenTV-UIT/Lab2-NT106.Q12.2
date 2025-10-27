using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2_LTMCB
{
    public partial class Bai1 : Form
    {
        public Bai1()
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
            rtb_res.Text = line;
            sr.Close();
            fs.Close();
        }

        private void rtb_res_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_wrfile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output1.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(rtb_res.Text.ToUpper());
            sw.Close();

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            rtb_res.Clear();
            File.WriteAllText("output1.txt", string.Empty, Encoding.UTF8);
        }

        private void btn_rt2menu_Click(object sender, EventArgs e)
        {
            this.Close();
            new Lab2().Show();
        }
    }
}
