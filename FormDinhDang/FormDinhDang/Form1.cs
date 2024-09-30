namespace FormDinhDang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void red_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text;
            lblOutput.ForeColor = System.Drawing.Color.Red;
        }

        private void InDam_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void InNghieng_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void GachChan_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }
        private void UpdateFontStyle()
        {
            FontStyle fontStyle = FontStyle.Regular;

            if (InDam.Checked)
            {
                fontStyle |= FontStyle.Bold;
            }
            if (InNghieng.Checked)
            {
                fontStyle |= FontStyle.Italic;
            }
            if (GachChan.Checked)
            {
                fontStyle |= FontStyle.Underline;
            }

            lblOutput.Font = new Font(lblOutput.Font, fontStyle);
        }

        private void green_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text;
            lblOutput.ForeColor = System.Drawing.Color.Green;
        }

        private void blue_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text;
            lblOutput.ForeColor = System.Drawing.Color.Blue;
        }

        private void black_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text;
            lblOutput.ForeColor = System.Drawing.Color.Black;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
