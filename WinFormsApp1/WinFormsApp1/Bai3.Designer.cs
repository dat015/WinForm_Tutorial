namespace WinFormsApp1
{
    partial class Bai3
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
            listView = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteMenu = new ToolStripMenuItem();
            EditMenu = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnRemoveAll = new Button();
            btnRemove = new Button();
            btnUpdate = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView
            // 
            listView.ContextMenuStrip = contextMenuStrip1;
            listView.LabelEdit = true;
            listView.Location = new Point(1, 264);
            listView.Name = "listView";
            listView.Size = new Size(800, 188);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            listView.MouseDown += listView_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteMenu, EditMenu });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(241, 101);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // deleteMenu
            // 
            deleteMenu.Name = "deleteMenu";
            deleteMenu.Size = new Size(240, 32);
            deleteMenu.Text = "Delete";
            deleteMenu.Click += deleteMenu_Click;
            // 
            // EditMenu
            // 
            EditMenu.Name = "EditMenu";
            EditMenu.Size = new Size(240, 32);
            EditMenu.Text = "Edit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 46);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 1;
            label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 112);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên SP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 174);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 3;
            label3.Text = "Giá SP";
            // 
            // txtID
            // 
            txtID.Location = new Point(228, 43);
            txtID.Name = "txtID";
            txtID.Size = new Size(291, 31);
            txtID.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(228, 109);
            txtName.Name = "txtName";
            txtName.Size = new Size(291, 31);
            txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(228, 171);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(291, 31);
            txtPrice.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(617, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(617, 94);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(112, 34);
            btnRemoveAll.TabIndex = 8;
            btnRemoveAll.Text = "Remove All";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(617, 150);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(112, 34);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(617, 204);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnRemoveAll);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView);
            Name = "Form4";
            Text = "Form4";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnRemoveAll;
        private Button btnRemove;
        private Button btnUpdate;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteMenu;
        private ToolStripMenuItem EditMenu;
    }
}