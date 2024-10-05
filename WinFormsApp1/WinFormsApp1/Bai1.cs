using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        public int Rd(int x, int y)
        {
            Random random = new Random();
            return random.Next(x, y);
        }
        private void lblNum1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {

            // Kiểm tra số tiền trước khi trừ tiền và bắt đầu quay
            if (int.Parse(lblMoney.Text) < 20)
            {
                MessageBox.Show("Số tiền hiện tại nhỏ hơn 20, vui lòng nạp thêm xu để tiếp tục chơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Trừ 20 xu
            lblMoney.Text = (int.Parse(lblMoney.Text) - 20).ToString();


            timer_Tick(sender, e);


        }
        private void UpdateNumbers(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblNum1.Text = rnd.Next(0, 7).ToString();
            lblNum2.Text = rnd.Next(0, 8).ToString();
            lblNum3.Text = rnd.Next(0, 9).ToString();
        }



        private void timer_Tick(object sender, EventArgs e)
        {
            if (timer == null)
            {
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 400;
                timer.Tick += new EventHandler(UpdateNumbers);
            }

            timer.Start();

            UpdateNumbers(null, null);
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                if (int.Parse(lblNum1.Text) == 7)
                {
                    lblMoney.Text = (int.Parse(lblMoney.Text) + 30).ToString();
                }
                if (int.Parse(lblNum2.Text) == 7)
                {
                    lblMoney.Text = (int.Parse(lblMoney.Text) + 40).ToString();

                }
                if (int.Parse(lblNum3.Text) == 7)
                {
                    lblMoney.Text = (int.Parse(lblMoney.Text) + 50).ToString();

                }
                return;
            }
        }

        private void btnGameMoi_Click(object sender, EventArgs e)
        {
            lblMoney.Text = "100";
            lblNum1.Text = "";
            lblNum2.Text = "";
            lblNum3.Text = "";

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?",
                                         "Xác nhận",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}
