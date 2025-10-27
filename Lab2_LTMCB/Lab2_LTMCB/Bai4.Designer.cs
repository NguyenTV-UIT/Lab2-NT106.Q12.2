namespace Lab2_LTMCB
{
    partial class Bai4
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
            btn_prev = new Button();
            btn_next = new Button();
            btn_add = new Button();
            lb_pagenum = new Label();
            tb_id = new TextBox();
            tb_phone = new TextBox();
            tb_grade1 = new TextBox();
            tb_grade2 = new TextBox();
            tb_grade3 = new TextBox();
            tb_name = new TextBox();
            tb_avggrade = new TextBox();
            tb2_avggrade = new TextBox();
            tb2_name = new TextBox();
            tb2_grade3 = new TextBox();
            tb2_grade2 = new TextBox();
            tb2_grade1 = new TextBox();
            tb2_phone = new TextBox();
            tb2_id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            tb_show = new TextBox();
            btn_wrfile = new Button();
            btn_rdfile = new Button();
            SuspendLayout();
            // 
            // btn_prev
            // 
            btn_prev.Location = new Point(741, 675);
            btn_prev.Name = "btn_prev";
            btn_prev.Size = new Size(112, 34);
            btn_prev.TabIndex = 0;
            btn_prev.Text = "Prev";
            btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(971, 675);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(112, 34);
            btn_next.TabIndex = 1;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(157, 675);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 34);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // lb_pagenum
            // 
            lb_pagenum.AutoSize = true;
            lb_pagenum.Location = new Point(890, 675);
            lb_pagenum.Name = "lb_pagenum";
            lb_pagenum.Size = new Size(22, 25);
            lb_pagenum.TabIndex = 3;
            lb_pagenum.Text = "0";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(243, 167);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(150, 31);
            tb_id.TabIndex = 4;
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(243, 236);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(150, 31);
            tb_phone.TabIndex = 5;
            // 
            // tb_grade1
            // 
            tb_grade1.Location = new Point(243, 308);
            tb_grade1.Name = "tb_grade1";
            tb_grade1.Size = new Size(150, 31);
            tb_grade1.TabIndex = 6;
            // 
            // tb_grade2
            // 
            tb_grade2.Location = new Point(243, 378);
            tb_grade2.Name = "tb_grade2";
            tb_grade2.Size = new Size(150, 31);
            tb_grade2.TabIndex = 7;
            // 
            // tb_grade3
            // 
            tb_grade3.Location = new Point(243, 448);
            tb_grade3.Name = "tb_grade3";
            tb_grade3.Size = new Size(150, 31);
            tb_grade3.TabIndex = 8;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(243, 100);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(150, 31);
            tb_name.TabIndex = 9;
            // 
            // tb_avggrade
            // 
            tb_avggrade.Enabled = false;
            tb_avggrade.Location = new Point(243, 522);
            tb_avggrade.Name = "tb_avggrade";
            tb_avggrade.Size = new Size(150, 31);
            tb_avggrade.TabIndex = 10;
            // 
            // tb2_avggrade
            // 
            tb2_avggrade.Location = new Point(741, 522);
            tb2_avggrade.Name = "tb2_avggrade";
            tb2_avggrade.ReadOnly = true;
            tb2_avggrade.Size = new Size(150, 31);
            tb2_avggrade.TabIndex = 17;
            // 
            // tb2_name
            // 
            tb2_name.Location = new Point(741, 100);
            tb2_name.Name = "tb2_name";
            tb2_name.ReadOnly = true;
            tb2_name.Size = new Size(150, 31);
            tb2_name.TabIndex = 16;
            // 
            // tb2_grade3
            // 
            tb2_grade3.Location = new Point(741, 448);
            tb2_grade3.Name = "tb2_grade3";
            tb2_grade3.ReadOnly = true;
            tb2_grade3.Size = new Size(150, 31);
            tb2_grade3.TabIndex = 15;
            // 
            // tb2_grade2
            // 
            tb2_grade2.Location = new Point(741, 378);
            tb2_grade2.Name = "tb2_grade2";
            tb2_grade2.ReadOnly = true;
            tb2_grade2.Size = new Size(150, 31);
            tb2_grade2.TabIndex = 14;
            // 
            // tb2_grade1
            // 
            tb2_grade1.Location = new Point(741, 308);
            tb2_grade1.Name = "tb2_grade1";
            tb2_grade1.ReadOnly = true;
            tb2_grade1.Size = new Size(150, 31);
            tb2_grade1.TabIndex = 13;
            // 
            // tb2_phone
            // 
            tb2_phone.Location = new Point(741, 236);
            tb2_phone.Name = "tb2_phone";
            tb2_phone.ReadOnly = true;
            tb2_phone.Size = new Size(150, 31);
            tb2_phone.TabIndex = 12;
            // 
            // tb2_id
            // 
            tb2_id.Location = new Point(741, 167);
            tb2_id.Name = "tb2_id";
            tb2_id.ReadOnly = true;
            tb2_id.Size = new Size(150, 31);
            tb2_id.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 100);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 18;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 167);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 19;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 236);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 20;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 308);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 21;
            label4.Text = "Course 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 378);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 22;
            label5.Text = "Course 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 448);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 23;
            label6.Text = "Course 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 522);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 24;
            label7.Text = "Average Grade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(935, 522);
            label8.Name = "label8";
            label8.Size = new Size(129, 25);
            label8.TabIndex = 31;
            label8.Text = "Average Grade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(935, 448);
            label9.Name = "label9";
            label9.Size = new Size(82, 25);
            label9.TabIndex = 30;
            label9.Text = "Course 3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(935, 378);
            label10.Name = "label10";
            label10.Size = new Size(82, 25);
            label10.TabIndex = 29;
            label10.Text = "Course 2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(935, 308);
            label11.Name = "label11";
            label11.Size = new Size(82, 25);
            label11.TabIndex = 28;
            label11.Text = "Course 1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(935, 236);
            label12.Name = "label12";
            label12.Size = new Size(62, 25);
            label12.TabIndex = 27;
            label12.Text = "Phone";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(935, 167);
            label13.Name = "label13";
            label13.Size = new Size(30, 25);
            label13.TabIndex = 26;
            label13.Text = "ID";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(935, 100);
            label14.Name = "label14";
            label14.Size = new Size(59, 25);
            label14.TabIndex = 25;
            label14.Text = "Name";
            // 
            // tb_show
            // 
            tb_show.Location = new Point(411, 100);
            tb_show.Multiline = true;
            tb_show.Name = "tb_show";
            tb_show.Size = new Size(308, 453);
            tb_show.TabIndex = 32;
            // 
            // btn_wrfile
            // 
            btn_wrfile.Location = new Point(263, 28);
            btn_wrfile.Name = "btn_wrfile";
            btn_wrfile.Size = new Size(112, 34);
            btn_wrfile.TabIndex = 33;
            btn_wrfile.Text = "Write File";
            btn_wrfile.UseVisualStyleBackColor = true;
            btn_wrfile.Click += btn_wrfile_Click;
            // 
            // btn_rdfile
            // 
            btn_rdfile.Location = new Point(759, 28);
            btn_rdfile.Name = "btn_rdfile";
            btn_rdfile.Size = new Size(112, 34);
            btn_rdfile.TabIndex = 34;
            btn_rdfile.Text = "Read File";
            btn_rdfile.UseVisualStyleBackColor = true;
            btn_rdfile.Click += btn_rdfile_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 755);
            Controls.Add(btn_rdfile);
            Controls.Add(btn_wrfile);
            Controls.Add(tb_show);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb2_avggrade);
            Controls.Add(tb2_name);
            Controls.Add(tb2_grade3);
            Controls.Add(tb2_grade2);
            Controls.Add(tb2_grade1);
            Controls.Add(tb2_phone);
            Controls.Add(tb2_id);
            Controls.Add(tb_avggrade);
            Controls.Add(tb_name);
            Controls.Add(tb_grade3);
            Controls.Add(tb_grade2);
            Controls.Add(tb_grade1);
            Controls.Add(tb_phone);
            Controls.Add(tb_id);
            Controls.Add(lb_pagenum);
            Controls.Add(btn_add);
            Controls.Add(btn_next);
            Controls.Add(btn_prev);
            Name = "Bai4";
            Text = "Bài 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_prev;
        private Button btn_next;
        private Button btn_add;
        private Label lb_pagenum;
        private TextBox tb_id;
        private TextBox tb_phone;
        private TextBox tb_grade1;
        private TextBox tb_grade2;
        private TextBox tb_grade3;
        private TextBox tb_name;
        private TextBox tb_avggrade;
        private TextBox tb2_avggrade;
        private TextBox tb2_name;
        private TextBox tb2_grade3;
        private TextBox tb2_grade2;
        private TextBox tb2_grade1;
        private TextBox tb2_phone;
        private TextBox tb2_id;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox tb_show;
        private Button btn_wrfile;
        private Button btn_rdfile;
    }
}