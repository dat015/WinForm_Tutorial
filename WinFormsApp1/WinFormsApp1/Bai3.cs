using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Bai3 : Form
    {
        public List<Product> Products;
        public Bai3()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            Products = new List<Product>();
            listView.View = View.Details;
            listView.Columns.Add("ID", 100);
            listView.Columns.Add("Product Name", 500);
            listView.Columns.Add("Price", 300);

            listView.FullRowSelect = true;// cho phép click vào bất kì ở item

            Product newProduct = new Product(1, "Product 1", (decimal)100.00);
            Products.Add(newProduct);

            foreach (var product in Products)
            {
                ListViewItem item = new ListViewItem(product.Id.ToString());
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Price.ToString());

                listView.Items.Add(item);
            }
        }



        private void DisplayProducts()
        {

            listView.Items.Clear();

            foreach (var product in Products)
            {
                ListViewItem item = new ListViewItem(product.Id.ToString());
                item.SubItems.Add(product.Name.ToString());
                item.SubItems.Add(product.Price.ToString());

                listView.Items.Add(item);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPrice.Text != "" && txtID.Text != "")
            {
                foreach (var item in Products)
                {
                    if (item.Id == int.Parse(txtID.Text))
                    {
                        MessageBox.Show("Id bị trùng với sản phẩm khác");
                        txtID.Text = "";
                        return;
                    }
                }
                Product newProduct = new Product(int.Parse(txtID.Text), txtName.Text, decimal.Parse(txtPrice.Text));

                Products.Add(newProduct);
                DisplayProducts();
                txtID.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
            }

        }

        private void listView_SelectedIndexChanged(object sender, MouseEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                int index = selectedItem.Index;

                if (decimal.TryParse(txtPrice.Text, out decimal price) && !string.IsNullOrEmpty(txtName.Text))
                {
                    Products[index].Name = txtName.Text;
                    Products[index].Price = price;

                    selectedItem.SubItems[1].Text = txtName.Text;
                    selectedItem.SubItems[2].Text = price.ToString();
                    txtID.Text = "";
                    txtName.Text = "";
                    txtPrice.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];

                string id = selectedItem.SubItems[0].Text;
                string productName = selectedItem.SubItems[1].Text;
                string price = selectedItem.SubItems[2].Text;

                txtID.Text = id;
                txtName.Text = productName;
                txtPrice.Text = price;
                btnUpdate.Enabled = true;
            }

        }
        private void listView_MouseDown(object sender, MouseEventArgs e)
        {

        }



        private void deleteMenu_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                int index = selectedItem.Index;

                var result = MessageBox.Show("Bạn có muốn xóa sản phẩm",
                                        "Xóa sản phẩm",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Products.RemoveAt(index);

                    listView.Items.Remove(selectedItem);
                }
            }
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            deleteMenu_Click(sender, e);

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả sản phẩm không?",
                                         "Xác nhận xóa tất cả",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Products.Clear();
                listView.Items.Clear();
                txtID.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
            }
        }


    }
}
