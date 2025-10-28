namespace Lab2_LTMCB
{
    partial class Bai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_rdfile = new Button();
            btn_exit = new Button();
            rtb_res = new RichTextBox();
            tb_filename = new TextBox();
            tb_size = new TextBox();
            tb_URL = new TextBox();
            tb_linecount = new TextBox();
            tb_wordcount = new TextBox();
            tb_charcount = new TextBox();
            SuspendLayout();
            // 
            // btn_rdfile
            // 
            btn_rdfile.Location = new Point(12, 12);
            btn_rdfile.Name = "btn_rdfile";
            btn_rdfile.Size = new Size(392, 34);
            btn_rdfile.TabIndex = 0;
            btn_rdfile.Text = "Đọc File";
            btn_rdfile.UseVisualStyleBackColor = true;
            btn_rdfile.Click += btn_rdfile_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(12, 404);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(392, 34);
            btn_exit.TabIndex = 1;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // rtb_res
            // 
            rtb_res.Location = new Point(420, 12);
            rtb_res.Name = "rtb_res";
            rtb_res.Size = new Size(434, 426);
            rtb_res.TabIndex = 2;
            rtb_res.Text = "";
            // 
            // tb_filename
            // 
            tb_filename.Location = new Point(12, 70);
            tb_filename.Name = "tb_filename";
            tb_filename.Size = new Size(392, 31);
            tb_filename.TabIndex = 3;
            tb_filename.Text = "Tên File";
            // 
            // tb_size
            // 
            tb_size.Location = new Point(12, 123);
            tb_size.Name = "tb_size";
            tb_size.Size = new Size(392, 31);
            tb_size.TabIndex = 4;
            tb_size.Text = "Size";
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(12, 179);
            tb_URL.Name = "tb_URL";
            tb_URL.Size = new Size(392, 31);
            tb_URL.TabIndex = 5;
            tb_URL.Text = "URL";
            // 
            // tb_linecount
            // 
            tb_linecount.Location = new Point(12, 233);
            tb_linecount.Name = "tb_linecount";
            tb_linecount.Size = new Size(392, 31);
            tb_linecount.TabIndex = 6;
            tb_linecount.Text = "Số dòng";
            // 
            // tb_wordcount
            // 
            tb_wordcount.Location = new Point(12, 292);
            tb_wordcount.Name = "tb_wordcount";
            tb_wordcount.Size = new Size(392, 31);
            tb_wordcount.TabIndex = 7;
            tb_wordcount.Text = "Số từ";
            // 
            // tb_charcount
            // 
            tb_charcount.Location = new Point(12, 350);
            tb_charcount.Name = "tb_charcount";
            tb_charcount.Size = new Size(392, 31);
            tb_charcount.TabIndex = 8;
            tb_charcount.Text = "Số kí tự";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 450);
            Controls.Add(tb_charcount);
            Controls.Add(tb_wordcount);
            Controls.Add(tb_linecount);
            Controls.Add(tb_URL);
            Controls.Add(tb_size);
            Controls.Add(tb_filename);
            Controls.Add(rtb_res);
            Controls.Add(btn_exit);
            Controls.Add(btn_rdfile);
            Name = "Bai2";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_rdfile;
        private Button btn_exit;
        private RichTextBox rtb_res;
        private TextBox tb_filename;
        private TextBox tb_size;
        private TextBox tb_URL;
        private TextBox tb_linecount;
        private TextBox tb_wordcount;
        private TextBox tb_charcount;
    }
}