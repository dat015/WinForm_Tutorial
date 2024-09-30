namespace FormDangKiXemPhim
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            button1 = new Button();
            dtpNgayDangKy = new DateTimePicker();
            label3 = new Label();
            txtTuoi = new TextBox();
            txtPhone = new TextBox();
            label2 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            errorPhone = new ErrorProvider(components);
            errorTuoi = new ErrorProvider(components);
            errorTime = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorTuoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorTime).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dtpNgayDangKy);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTuoi);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(40, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 386);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng kí";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(296, 317);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(133, 44);
            button1.TabIndex = 6;
            button1.Text = "Đăng kí";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.Format = DateTimePickerFormat.Short;
            dtpNgayDangKy.Location = new Point(296, 237);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(300, 37);
            dtpNgayDangKy.TabIndex = 5;
            dtpNgayDangKy.ValueChanged += dtpNgayDangKy_ValueChanged;
            // 
            // label3
            // 
            label3.Location = new Point(106, 236);
            label3.Name = "label3";
            label3.Size = new Size(173, 38);
            label3.TabIndex = 4;
            label3.Text = "Ngày đăng ký:";
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(296, 154);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(300, 37);
            txtTuoi.TabIndex = 3;
            txtTuoi.TextChanged += txtTuoi_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(296, 80);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 37);
            txtPhone.TabIndex = 2;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 154);
            label2.Name = "label2";
            label2.Size = new Size(56, 30);
            label2.TabIndex = 1;
            label2.Text = "Tuổi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 80);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 0;
            label1.Text = "Phone";
            // 
            // errorPhone
            // 
            errorPhone.ContainerControl = this;
            // 
            // errorTuoi
            // 
            errorTuoi.ContainerControl = this;
            // 
            // errorTime
            // 
            errorTime.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorTuoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorTime).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpNgayDangKy;
        private Label label3;
        private TextBox txtTuoi;
        private TextBox txtPhone;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ErrorProvider errorPhone;
        private ErrorProvider errorTuoi;
        private ErrorProvider errorTime;
        private Button button1;
    }
}
