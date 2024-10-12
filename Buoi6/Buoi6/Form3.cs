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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBoxOptions.Items.Add("*.jpg;*.jpeg;*.png");
            comboBoxOptions.Items.Add("*.xls;*.xlsx");
            comboBoxOptions.Items.Add("*.doc;*.docx");
            comboBoxOptions.Items.Add("*.ppt;*.pptx");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (comboBoxOptions.Text == "")
            {
                MessageBox.Show("Chưa chọn kiểu file!");
                return;
            }

            FolderBrowserDialog folderDialog = new FolderBrowserDialog
            {
                Description = "Chọn thư mục chứa các file cần di chuyển"
            };

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceDirectory = folderDialog.SelectedPath;
                txtStart.Text = sourceDirectory;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thư mục nguồn.");
            }
        }


        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStart.Text) || string.IsNullOrEmpty(txtEnd.Text))
            {
                MessageBox.Show("Bạn chưa chọn đầy đủ thư mục nguồn và thư mục đích.");
                return;
            }

            if (comboBoxOptions.Text == "")
            {
                MessageBox.Show("Chưa chọn kiểu file!");
                return;
            }

            string sourceDirectory = txtStart.Text;
            string destinationDirectory = txtEnd.Text;
            string selectedOption = comboBoxOptions.Text;

            string[] filePatterns = selectedOption.Split(';');

            if (!Directory.Exists(sourceDirectory))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại.");
                return;
            }

            if (!Directory.Exists(destinationDirectory))
            {
                MessageBox.Show("Thư mục đích không tồn tại.");
                return;
            }

            try
            {
                int totalFiles = 0;
                foreach (string pattern in filePatterns)
                {
                    if (string.IsNullOrWhiteSpace(pattern)) continue;
                    totalFiles += Directory.GetFiles(sourceDirectory, pattern.Trim()).Length;
                }

                progressBar1.Minimum = 0;
                progressBar1.Maximum = totalFiles;
                progressBar1.Value = 0;

                int processedFiles = 0;

                foreach (string pattern in filePatterns)
                {
                    if (string.IsNullOrWhiteSpace(pattern)) continue;

                    string[] files = Directory.GetFiles(sourceDirectory, pattern.Trim());

                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        string destFile = Path.Combine(destinationDirectory, fileName);

                        if (File.Exists(destFile))
                        {
                            DialogResult result = MessageBox.Show($"File '{fileName}' đã tồn tại. Bạn có muốn ghi đè không?", "Xác nhận ghi đè", MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                continue;
                            }
                        }

                        File.Copy(file, destFile, true);
                        processedFiles++;

                        progressBar1.Value = processedFiles;
                        label4.Text = processedFiles + "/" + totalFiles;

                    }
                }

                MessageBox.Show("Sao chép file thành công!");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào thư mục hoặc file. " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi trong quá trình sao chép file. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }



        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (comboBoxOptions.Text == "")
            {
                MessageBox.Show("Chưa chọn kiểu file!");
                return;
            }

            FolderBrowserDialog folderDialog = new FolderBrowserDialog
            {
                Description = "Chọn thư mục đích"
            };

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceDirectory = folderDialog.SelectedPath;
                txtEnd.Text = sourceDirectory;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thư mục nguồn.");
            }
        }


        private void btnCutFile_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStart.Text) || string.IsNullOrEmpty(txtEnd.Text))
            {
                MessageBox.Show("Bạn chưa chọn đầy đủ thư mục nguồn và thư mục đích.");
                return;
            }

            if (comboBoxOptions.Text == "")
            {
                MessageBox.Show("Chưa chọn kiểu file!");
                return;
            }

            string sourceDirectory = txtStart.Text;
            string destinationDirectory = txtEnd.Text;
            string selectedOption = comboBoxOptions.Text;

            // Tách các kiểu file từ chuỗi được chọn
            string[] filePatterns = selectedOption.Split(';');

            // Khởi tạo ProgressBar
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;

            try
            {
                int totalFiles = 0;

                foreach (string pattern in filePatterns)
                {
                    if (string.IsNullOrWhiteSpace(pattern)) continue;
                    totalFiles += Directory.GetFiles(sourceDirectory, pattern.Trim()).Length;
                }

                progressBar1.Maximum = totalFiles;

                int processedFiles = 0;

                foreach (string pattern in filePatterns)
                {
                    if (string.IsNullOrWhiteSpace(pattern)) continue;

                    string[] files = Directory.GetFiles(sourceDirectory, pattern.Trim());

                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        string destFile = Path.Combine(destinationDirectory, fileName);

                        if (File.Exists(destFile))
                        {
                            DialogResult result = MessageBox.Show($"File '{fileName}' đã tồn tại. Bạn có muốn ghi đè không?",
                                                                  "Xác nhận ghi đè",
                                                                  MessageBoxButtons.YesNo);
                            if (result == DialogResult.No)
                            {
                                continue;
                            }
                        }

                        File.Move(file, destFile);
                        processedFiles++;

                        progressBar1.Value = processedFiles;

                        // Cập nhật label4 với số lượng file đã di chuyển
                        label4.Text = processedFiles + "/" + totalFiles;
                    }
                }

                MessageBox.Show("Di chuyển file thành công!");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào thư mục hoặc file. " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi trong quá trình di chuyển file. " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
