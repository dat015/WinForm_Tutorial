namespace FormDinhDang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInput = new Label();
            txtInput = new TextBox();
            red = new RadioButton();
            green = new RadioButton();
            blue = new RadioButton();
            black = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            GachChan = new CheckBox();
            InNghieng = new CheckBox();
            InDam = new CheckBox();
            lblHienThi = new Label();
            lblOutput = new Label();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInput.Location = new Point(116, 41);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(69, 30);
            lblInput.TabIndex = 0;
            lblInput.Text = "Input";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(217, 42);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(401, 31);
            txtInput.TabIndex = 1;
            // 
            // red
            // 
            red.AutoSize = true;
            red.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            red.ForeColor = Color.Red;
            red.Location = new Point(32, 30);
            red.Name = "red";
            red.Size = new Size(70, 29);
            red.TabIndex = 2;
            red.TabStop = true;
            red.Text = "Red";
            red.UseVisualStyleBackColor = true;
            red.CheckedChanged += red_CheckedChanged;
            // 
            // green
            // 
            green.AutoSize = true;
            green.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            green.ForeColor = Color.Green;
            green.Location = new Point(32, 65);
            green.Name = "green";
            green.Size = new Size(88, 29);
            green.TabIndex = 3;
            green.TabStop = true;
            green.Text = "Green";
            green.UseVisualStyleBackColor = true;
            green.CheckedChanged += green_CheckedChanged;
            // 
            // blue
            // 
            blue.AutoSize = true;
            blue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            blue.ForeColor = Color.Blue;
            blue.Location = new Point(32, 100);
            blue.Name = "blue";
            blue.Size = new Size(75, 29);
            blue.TabIndex = 4;
            blue.TabStop = true;
            blue.Text = "Blue";
            blue.UseVisualStyleBackColor = true;
            blue.CheckedChanged += blue_CheckedChanged;
            // 
            // black
            // 
            black.AutoSize = true;
            black.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            black.ForeColor = Color.Black;
            black.Location = new Point(32, 135);
            black.Name = "black";
            black.Size = new Size(83, 29);
            black.TabIndex = 5;
            black.TabStop = true;
            black.Text = "Black";
            black.UseVisualStyleBackColor = true;
            black.CheckedChanged += black_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(red);
            groupBox1.Controls.Add(black);
            groupBox1.Controls.Add(green);
            groupBox1.Controls.Add(blue);
            groupBox1.Location = new Point(37, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 184);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 128, 128);
            groupBox2.Controls.Add(GachChan);
            groupBox2.Controls.Add(InNghieng);
            groupBox2.Controls.Add(InDam);
            groupBox2.Location = new Point(522, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 184);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font chữ";
            // 
            // GachChan
            // 
            GachChan.AutoSize = true;
            GachChan.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            GachChan.Location = new Point(37, 112);
            GachChan.Name = "GachChan";
            GachChan.Size = new Size(203, 29);
            GachChan.TabIndex = 2;
            GachChan.Text = "Gạch chân (Undeline)";
            GachChan.UseVisualStyleBackColor = true;
            GachChan.CheckedChanged += GachChan_CheckedChanged;
            // 
            // InNghieng
            // 
            InNghieng.AutoSize = true;
            InNghieng.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            InNghieng.Location = new Point(37, 77);
            InNghieng.Name = "InNghieng";
            InNghieng.Size = new Size(176, 29);
            InNghieng.TabIndex = 1;
            InNghieng.Text = "In nghiêng (Italic)";
            InNghieng.UseVisualStyleBackColor = true;
            InNghieng.CheckedChanged += InNghieng_CheckedChanged;
            // 
            // InDam
            // 
            InDam.AutoSize = true;
            InDam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InDam.Location = new Point(37, 42);
            InDam.Name = "InDam";
            InDam.Size = new Size(151, 29);
            InDam.TabIndex = 0;
            InDam.Text = "In đậm (Botl)";
            InDam.UseVisualStyleBackColor = true;
            InDam.CheckedChanged += InDam_CheckedChanged;
            // 
            // lblHienThi
            // 
            lblHienThi.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHienThi.Location = new Point(36, 380);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(136, 40);
            lblHienThi.TabIndex = 8;
            lblHienThi.Text = "Hiển Thị";
            lblHienThi.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(217, 368);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(327, 61);
            lblOutput.TabIndex = 9;
            lblOutput.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(598, 368);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 61);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(lblOutput);
            Controls.Add(lblHienThi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private RadioButton red;
        private RadioButton green;
        private RadioButton blue;
        private RadioButton black;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox GachChan;
        private CheckBox InNghieng;
        private CheckBox InDam;
        private Label lblHienThi;
        private Label lblOutput;
        private Button btnThoat;
    }
}
