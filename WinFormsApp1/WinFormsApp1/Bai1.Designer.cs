namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblNum3 = new Label();
            label1 = new Label();
            lblMoney = new Label();
            btnQuaySo = new Button();
            btnStop = new Button();
            btnGameMoi = new Button();
            btnKetThuc = new Button();
            timer = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.BackColor = SystemColors.ActiveBorder;
            lblNum1.BorderStyle = BorderStyle.Fixed3D;
            lblNum1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum1.ForeColor = Color.Coral;
            lblNum1.Location = new Point(79, 94);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(171, 140);
            lblNum1.TabIndex = 0;
            lblNum1.TextAlign = ContentAlignment.MiddleCenter;
            lblNum1.Click += lblNum1_Click;
            // 
            // lblNum2
            // 
            lblNum2.BackColor = SystemColors.ActiveBorder;
            lblNum2.BorderStyle = BorderStyle.Fixed3D;
            lblNum2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum2.ForeColor = Color.Coral;
            lblNum2.Location = new Point(319, 94);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(171, 140);
            lblNum2.TabIndex = 1;
            lblNum2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum3
            // 
            lblNum3.BackColor = SystemColors.ActiveBorder;
            lblNum3.BorderStyle = BorderStyle.Fixed3D;
            lblNum3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum3.ForeColor = Color.Coral;
            lblNum3.Location = new Point(562, 94);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(171, 140);
            lblNum3.TabIndex = 2;
            lblNum3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 284);
            label1.Name = "label1";
            label1.Size = new Size(177, 35);
            label1.TabIndex = 3;
            label1.Text = "Tiền người chơi";
            // 
            // lblMoney
            // 
            lblMoney.BorderStyle = BorderStyle.FixedSingle;
            lblMoney.Cursor = Cursors.IBeam;
            lblMoney.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMoney.ForeColor = SystemColors.Highlight;
            lblMoney.Location = new Point(274, 284);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(354, 35);
            lblMoney.TabIndex = 4;
            lblMoney.Text = "100";
            lblMoney.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnQuaySo
            // 
            btnQuaySo.Location = new Point(79, 346);
            btnQuaySo.Name = "btnQuaySo";
            btnQuaySo.Size = new Size(112, 34);
            btnQuaySo.TabIndex = 5;
            btnQuaySo.Text = "Quay số";
            btnQuaySo.UseVisualStyleBackColor = true;
            btnQuaySo.Click += btnQuaySo_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(362, 346);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(112, 34);
            btnStop.TabIndex = 6;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click_1;
            // 
            // btnGameMoi
            // 
            btnGameMoi.Location = new Point(621, 346);
            btnGameMoi.Name = "btnGameMoi";
            btnGameMoi.Size = new Size(112, 34);
            btnGameMoi.TabIndex = 7;
            btnGameMoi.Text = "Game mới";
            btnGameMoi.UseVisualStyleBackColor = true;
            btnGameMoi.Click += btnGameMoi_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(307, 404);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(246, 34);
            btnKetThuc.TabIndex = 8;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKetThuc);
            Controls.Add(btnGameMoi);
            Controls.Add(btnStop);
            Controls.Add(btnQuaySo);
            Controls.Add(lblMoney);
            Controls.Add(label1);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private Label label1;
        private Label lblMoney;
        private Button btnQuaySo;
        private Button btnStop;
        private Button btnGameMoi;
        private Button btnKetThuc;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}