using System.IO;

namespace Buoi6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string path = txtLink.Text;
            if (Directory.Exists(path))
            {
                string[] directories = Directory.GetDirectories(path);
                int dirCount = directories.Length;


                string[] files = Directory.GetFiles(path);
                int fileCount = files.Length;
                lblFile.Text = fileCount.ToString();
                lblFolder.Text = dirCount.ToString();

            }
            else
            {
                MessageBox.Show("Đường dẫn không hợp lệ hoặc không tồn tại.");
            }
        }
    }
}
