namespace Lab2_LTMCB
{
    partial class Bai6
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
            tlp_table = new TableLayoutPanel();
            btn_find = new Button();
            btn_reset = new Button();
            btn_quit = new Button();
            rtb_res = new RichTextBox();
            ptb_dish = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptb_dish).BeginInit();
            SuspendLayout();
            // 
            // tlp_table
            // 
            tlp_table.ColumnCount = 4;
            tlp_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.9419231F));
            tlp_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.058075F));
            tlp_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 351F));
            tlp_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tlp_table.Location = new Point(101, 109);
            tlp_table.Name = "tlp_table";
            tlp_table.RowCount = 2;
            tlp_table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_table.Size = new Size(921, 229);
            tlp_table.TabIndex = 0;
            // 
            // btn_find
            // 
            btn_find.Location = new Point(498, 384);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(112, 34);
            btn_find.TabIndex = 0;
            btn_find.Text = "TÌM";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += btn_find_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(910, 484);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(112, 34);
            btn_reset.TabIndex = 1;
            btn_reset.Text = "RESET";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_quit
            // 
            btn_quit.Location = new Point(910, 584);
            btn_quit.Name = "btn_quit";
            btn_quit.Size = new Size(112, 34);
            btn_quit.TabIndex = 2;
            btn_quit.Text = "THOÁT";
            btn_quit.UseVisualStyleBackColor = true;
            btn_quit.Click += this.btn_quit_Click;
            // 
            // rtb_res
            // 
            rtb_res.Location = new Point(311, 484);
            rtb_res.Name = "rtb_res";
            rtb_res.Size = new Size(571, 144);
            rtb_res.TabIndex = 4;
            rtb_res.Text = "";
            // 
            // ptb_dish
            // 
            ptb_dish.Location = new Point(101, 484);
            ptb_dish.Name = "ptb_dish";
            ptb_dish.Size = new Size(146, 144);
            ptb_dish.TabIndex = 5;
            ptb_dish.TabStop = false;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 685);
            Controls.Add(ptb_dish);
            Controls.Add(rtb_res);
            Controls.Add(btn_quit);
            Controls.Add(btn_reset);
            Controls.Add(btn_find);
            Controls.Add(tlp_table);
            Name = "Bai6";
            Text = "Bài 6";
            ((System.ComponentModel.ISupportInitialize)ptb_dish).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_table;
        private Button btn_find;
        private Button btn_reset;
        private Button btn_quit;
        private RichTextBox rtb_res;
        private PictureBox ptb_dish;
    }
}