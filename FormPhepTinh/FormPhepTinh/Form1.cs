namespace FormPhepTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsInteger(string input)
        {
            return int.TryParse(input, out _);
        }
        public int GetNumber(TextBox txt)
        {
            return IsInteger(txt.Text) ? int.Parse(txt.Text) : 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = GetNumber(txtA);
                var num2 = GetNumber(txtB);
                if (num1 == 0 || num2 == 0)
                {
                    MessageBox.Show("Số nhập vào phải là số nguyên");
                    txtA.Text = "";
                    txtB.Text = "";
                }

                lblKetQua.Text = (num1 + num2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = GetNumber(txtA);
                var num2 = GetNumber(txtB);
                if (num1 == 0 || num2 == 0)
                {
                    MessageBox.Show("Số nhập vào phải là số nguyên");
                    txtA.Text = "";
                    txtB.Text = "";
                }

                lblKetQua.Text = (num1 - num2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            lblKetQua.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
