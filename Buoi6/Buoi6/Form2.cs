using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Chọn một hình ảnh";
            openFileDialog.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị hình ảnh đã chọn trong PictureBox
                ptb1.Image = Image.FromFile(openFileDialog.FileName);

                // Điều chỉnh kích thước của PictureBox để vừa với hình ảnh
                ptb1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
