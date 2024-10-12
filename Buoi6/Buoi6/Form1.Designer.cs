namespace Buoi6
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
            lblLink = new Label();
            txtLink = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblFile = new Label();
            lblFolder = new Label();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // lblLink
            // 
            lblLink.Location = new Point(134, 99);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(124, 38);
            lblLink.TabIndex = 0;
            lblLink.Text = "Đường dẫn";
            // 
            // txtLink
            // 
            txtLink.Location = new Point(264, 99);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(387, 31);
            txtLink.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(134, 178);
            label1.Name = "label1";
            label1.Size = new Size(124, 38);
            label1.TabIndex = 2;
            label1.Text = "Tổng số file";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(102, 252);
            label2.Name = "label2";
            label2.Size = new Size(162, 38);
            label2.TabIndex = 3;
            label2.Text = "Tổng số thư mục";
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(264, 178);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(0, 25);
            lblFile.TabIndex = 4;
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(264, 252);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(0, 25);
            lblFolder.TabIndex = 5;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(318, 325);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(153, 34);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Kiểm tra";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCheck);
            Controls.Add(lblFolder);
            Controls.Add(lblFile);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLink);
            Controls.Add(lblLink);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLink;
        private TextBox txtLink;
        private Label label1;
        private Label label2;
        private Label lblFile;
        private Label lblFolder;
        private Button btnCheck;
    }
}
