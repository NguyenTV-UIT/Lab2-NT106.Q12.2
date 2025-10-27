namespace Lab2_LTMCB
{
    partial class Bai3
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
            btn_wrfile = new Button();
            btn_calc = new Button();
            rtb_calc = new RichTextBox();
            rtb_in = new RichTextBox();
            rtb_out = new RichTextBox();
            SuspendLayout();
            // 
            // btn_rdfile
            // 
            btn_rdfile.Location = new Point(12, 249);
            btn_rdfile.Name = "btn_rdfile";
            btn_rdfile.Size = new Size(112, 34);
            btn_rdfile.TabIndex = 0;
            btn_rdfile.Text = "Đọc FILE";
            btn_rdfile.UseVisualStyleBackColor = true;
            btn_rdfile.Click += btn_rdfile_Click;
            // 
            // btn_wrfile
            // 
            btn_wrfile.Location = new Point(595, 249);
            btn_wrfile.Name = "btn_wrfile";
            btn_wrfile.Size = new Size(112, 34);
            btn_wrfile.TabIndex = 1;
            btn_wrfile.Text = "Ghi FILE";
            btn_wrfile.UseVisualStyleBackColor = true;
            btn_wrfile.Click += btn_wrfile_Click;
            // 
            // btn_calc
            // 
            btn_calc.Location = new Point(595, 10);
            btn_calc.Name = "btn_calc";
            btn_calc.Size = new Size(93, 34);
            btn_calc.TabIndex = 2;
            btn_calc.Text = "Tính";
            btn_calc.UseVisualStyleBackColor = true;
            btn_calc.Click += btn_calc_Click;
            // 
            // rtb_calc
            // 
            rtb_calc.Location = new Point(694, 12);
            rtb_calc.Name = "rtb_calc";
            rtb_calc.Size = new Size(373, 216);
            rtb_calc.TabIndex = 3;
            rtb_calc.Text = "";
            // 
            // rtb_in
            // 
            rtb_in.Location = new Point(12, 299);
            rtb_in.Name = "rtb_in";
            rtb_in.Size = new Size(482, 300);
            rtb_in.TabIndex = 4;
            rtb_in.Text = "";
            // 
            // rtb_out
            // 
            rtb_out.Location = new Point(595, 299);
            rtb_out.Name = "rtb_out";
            rtb_out.Size = new Size(472, 300);
            rtb_out.TabIndex = 5;
            rtb_out.Text = "";
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 611);
            Controls.Add(rtb_out);
            Controls.Add(rtb_in);
            Controls.Add(rtb_calc);
            Controls.Add(btn_calc);
            Controls.Add(btn_wrfile);
            Controls.Add(btn_rdfile);
            Name = "Bai3";
            Text = "Bài 3";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_rdfile;
        private Button btn_wrfile;
        private Button btn_calc;
        private RichTextBox rtb_calc;
        private RichTextBox rtb_in;
        private RichTextBox rtb_out;
    }
}