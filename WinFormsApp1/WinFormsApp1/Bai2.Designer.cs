namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            btnStart = new Button();
            btnCancel = new Button();
            timer = new System.Windows.Forms.Timer(components);
            lblPersent = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(67, 184);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(671, 34);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(97, 97);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(576, 97);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // lblPersent
            // 
            lblPersent.AutoSize = true;
            lblPersent.Location = new Point(81, 260);
            lblPersent.Name = "lblPersent";
            lblPersent.Size = new Size(0, 25);
            lblPersent.TabIndex = 3;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPersent);
            Controls.Add(btnCancel);
            Controls.Add(btnStart);
            Controls.Add(progressBar1);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button btnStart;
        private Button btnCancel;
        private System.Windows.Forms.Timer timer;
        private Label lblPersent;
    }
}