namespace Buoi6
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            comboBoxOptions = new ComboBox();
            btnStart = new Button();
            btnEnd = new Button();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            btnExit = new Button();
            btnCutFile = new Button();
            btnCopyFile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(39, 51);
            label1.Name = "label1";
            label1.Size = new Size(88, 38);
            label1.TabIndex = 0;
            label1.Text = "Loại tệp";
            // 
            // label2
            // 
            label2.Location = new Point(21, 180);
            label2.Name = "label2";
            label2.Size = new Size(122, 38);
            label2.TabIndex = 1;
            label2.Text = "Thư mục đích";
            // 
            // label3
            // 
            label3.Location = new Point(21, 114);
            label3.Name = "label3";
            label3.Size = new Size(122, 38);
            label3.TabIndex = 2;
            label3.Text = "Thư mục gốc";
            // 
            // txtStart
            // 
            txtStart.Enabled = false;
            txtStart.Location = new Point(173, 111);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(408, 31);
            txtStart.TabIndex = 3;
            // 
            // txtEnd
            // 
            txtEnd.Enabled = false;
            txtEnd.Location = new Point(173, 177);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(408, 31);
            txtEnd.TabIndex = 4;
            // 
            // comboBoxOptions
            // 
            comboBoxOptions.FormattingEnabled = true;
            comboBoxOptions.Location = new Point(173, 51);
            comboBoxOptions.Name = "comboBoxOptions";
            comboBoxOptions.Size = new Size(182, 33);
            comboBoxOptions.TabIndex = 5;
            comboBoxOptions.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(629, 108);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 6;
            btnStart.Text = "Browser";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(629, 174);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(112, 34);
            btnEnd.TabIndex = 7;
            btnEnd.Text = "Browser";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(39, 263);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(542, 34);
            progressBar1.TabIndex = 8;
            progressBar1.Click += progressBar1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(629, 272);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 9;
            label4.Click += label4_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(86, 348);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCutFile
            // 
            btnCutFile.Location = new Point(359, 348);
            btnCutFile.Name = "btnCutFile";
            btnCutFile.Size = new Size(112, 34);
            btnCutFile.TabIndex = 11;
            btnCutFile.Text = "Cắt File";
            btnCutFile.UseVisualStyleBackColor = true;
            btnCutFile.Click += btnCutFile_Click_1;
            // 
            // btnCopyFile
            // 
            btnCopyFile.Location = new Point(629, 348);
            btnCopyFile.Name = "btnCopyFile";
            btnCopyFile.Size = new Size(112, 34);
            btnCopyFile.TabIndex = 12;
            btnCopyFile.Text = "Copy File";
            btnCopyFile.UseVisualStyleBackColor = true;
            btnCopyFile.Click += btnCopyFile_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCopyFile);
            Controls.Add(btnCutFile);
            Controls.Add(btnExit);
            Controls.Add(label4);
            Controls.Add(progressBar1);
            Controls.Add(btnEnd);
            Controls.Add(btnStart);
            Controls.Add(comboBoxOptions);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtStart;
        private TextBox txtEnd;
        private ComboBox comboBoxOptions;
        private Button btnStart;
        private Button btnEnd;
        private ProgressBar progressBar1;
        private Label label4;
        private Button btnExit;
        private Button btnCutFile;
        private Button btnCopyFile;
    }
}