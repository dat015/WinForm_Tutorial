namespace FormPhepTinh
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
            lblKetQua = new Label();
            lblA = new Label();
            lblB = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            btnTong = new Button();
            btnHieu = new Button();
            btnReset = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblKetQua
            // 
            lblKetQua.BackColor = SystemColors.Highlight;
            lblKetQua.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKetQua.Location = new Point(1, 9);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(787, 73);
            lblKetQua.TabIndex = 0;
            lblKetQua.TextAlign = ContentAlignment.TopCenter;
            lblKetQua.Click += label1_Click;
            // 
            // lblA
            // 
            lblA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblA.Location = new Point(71, 141);
            lblA.Name = "lblA";
            lblA.Size = new Size(175, 38);
            lblA.TabIndex = 1;
            lblA.Text = "Số nguyên a:";
            lblA.Click += label1_Click_1;
            // 
            // lblB
            // 
            lblB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblB.Location = new Point(71, 197);
            lblB.Name = "lblB";
            lblB.Size = new Size(175, 38);
            lblB.TabIndex = 2;
            lblB.Text = "Số nguyên b:";
            lblB.Click += label2_Click;
            // 
            // txtA
            // 
            txtA.BorderStyle = BorderStyle.FixedSingle;
            txtA.Location = new Point(252, 141);
            txtA.Name = "txtA";
            txtA.Size = new Size(296, 31);
            txtA.TabIndex = 3;
            // 
            // txtB
            // 
            txtB.BorderStyle = BorderStyle.FixedSingle;
            txtB.Location = new Point(252, 197);
            txtB.Name = "txtB";
            txtB.Size = new Size(296, 31);
            txtB.TabIndex = 4;
            // 
            // btnTong
            // 
            btnTong.BackColor = Color.Orange;
            btnTong.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTong.Location = new Point(119, 302);
            btnTong.Name = "btnTong";
            btnTong.Padding = new Padding(2);
            btnTong.Size = new Size(127, 41);
            btnTong.TabIndex = 5;
            btnTong.Text = "Tổng";
            btnTong.UseVisualStyleBackColor = false;
            btnTong.Click += button1_Click;
            // 
            // btnHieu
            // 
            btnHieu.BackColor = SystemColors.Highlight;
            btnHieu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHieu.Location = new Point(313, 302);
            btnHieu.Name = "btnHieu";
            btnHieu.Padding = new Padding(2);
            btnHieu.Size = new Size(127, 41);
            btnHieu.TabIndex = 6;
            btnHieu.Text = "Hiệu";
            btnHieu.UseVisualStyleBackColor = false;
            btnHieu.Click += btnHieu_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.PeachPuff;
            btnReset.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(509, 302);
            btnReset.Name = "btnReset";
            btnReset.Padding = new Padding(2);
            btnReset.Size = new Size(127, 41);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Orchid;
            btnThoat.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(313, 382);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(2);
            btnThoat.Size = new Size(127, 41);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnReset);
            Controls.Add(btnHieu);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblKetQua);
            Controls.Add(btnTong);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKetQua;
        private Label lblA;
        private Label lblB;
        private TextBox txtA;
        private TextBox txtB;
        private Button btnTong;
        private Button btnHieu;
        private Button btnReset;
        private Button btnThoat;
    }
}
