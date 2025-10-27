namespace Lab2_LTMCB
{
    partial class Bai1
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
            rtb_res = new RichTextBox();
            btn_reset = new Button();
            btn_rt2menu = new Button();
            SuspendLayout();
            // 
            // btn_rdfile
            // 
            btn_rdfile.Location = new Point(99, 81);
            btn_rdfile.Name = "btn_rdfile";
            btn_rdfile.Size = new Size(112, 34);
            btn_rdfile.TabIndex = 1;
            btn_rdfile.Text = "ĐỌC FILE";
            btn_rdfile.UseVisualStyleBackColor = true;
            btn_rdfile.Click += btn_rdfile_Click;
            // 
            // btn_wrfile
            // 
            btn_wrfile.Location = new Point(99, 156);
            btn_wrfile.Name = "btn_wrfile";
            btn_wrfile.Size = new Size(112, 34);
            btn_wrfile.TabIndex = 2;
            btn_wrfile.Text = "GHI FILE";
            btn_wrfile.UseVisualStyleBackColor = true;
            btn_wrfile.Click += btn_wrfile_Click;
            // 
            // rtb_res
            // 
            rtb_res.Location = new Point(351, 34);
            rtb_res.Name = "rtb_res";
            rtb_res.Size = new Size(437, 404);
            rtb_res.TabIndex = 3;
            rtb_res.Text = "";
            rtb_res.TextChanged += rtb_res_TextChanged;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(99, 237);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(112, 34);
            btn_reset.TabIndex = 4;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_rt2menu
            // 
            btn_rt2menu.Location = new Point(99, 320);
            btn_rt2menu.Name = "btn_rt2menu";
            btn_rt2menu.Size = new Size(112, 34);
            btn_rt2menu.TabIndex = 5;
            btn_rt2menu.Text = "Quay Lại";
            btn_rt2menu.UseVisualStyleBackColor = true;
            btn_rt2menu.Click += btn_rt2menu_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_rt2menu);
            Controls.Add(btn_reset);
            Controls.Add(rtb_res);
            Controls.Add(btn_wrfile);
            Controls.Add(btn_rdfile);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_rdfile;
        private Button btn_wrfile;
        private RichTextBox rtb_res;
        private Button btn_reset;
        private Button btn_rt2menu;
    }
}