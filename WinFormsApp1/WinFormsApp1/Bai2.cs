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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;

            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
                lblPersent.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Hoàn thành!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer.Stop();

        }
    }
}
