using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace Lab2_LTMCB
{
    public partial class Bai2 : Form
    {
        public Bai2()
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
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadToEnd();
            rtb_res.Text = line;
            tb_filename.Text = ofd.SafeFileName.ToString();
            tb_size.Text = fs.Length.ToString() + " bytes";
            tb_URL.Text = fs.Name.ToString();
            tb_linecount.Text = rtb_res.Lines.Length.ToString();
            tb_wordcount.Text = rtb_res.Text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length.ToString();
            tb_charcount.Text = rtb_res.Text.Trim().Length.ToString();
            sr.Close();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
