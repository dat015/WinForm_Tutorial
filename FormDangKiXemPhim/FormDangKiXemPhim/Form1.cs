using System.Windows.Forms;

namespace FormDangKiXemPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ErrorProvider errorProvider = new ErrorProvider();
        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "Số điện thoại không được bỏ trống.");
                isValid = false;
            }

            int tuoi;
            if (!int.TryParse(txtTuoi.Text, out tuoi) || tuoi <= 17)
            {
                errorProvider.SetError(txtTuoi, "Tuổi phải lớn hơn 17.");
                isValid = false;
            }

            if (dtpNgayDangKy.Value.DayOfWeek == DayOfWeek.Monday)
            {
                errorProvider.SetError(dtpNgayDangKy, "Không được đăng ký vào thứ Hai.");
                isValid = false;
            }

            if (isValid)
            {
                MessageBox.Show("Bạn đã đăng ký thành công, chúng tôi sẽ liên hệ với bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "");
            }

        }

        private void txtTuoi_TextChanged(object sender, EventArgs e)
        {
            int tuoi;
            if (int.TryParse(txtTuoi.Text, out tuoi) && tuoi > 17)
            {
                errorProvider.SetError(txtTuoi, "");
            }
        }

        private void dtpNgayDangKy_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayDangKy.Value.DayOfWeek != DayOfWeek.Monday)
            {
                errorProvider.SetError(dtpNgayDangKy, "");
            }
        }
    }
}
