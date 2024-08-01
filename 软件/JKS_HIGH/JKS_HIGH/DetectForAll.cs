using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKS_HIGH
{
    public partial class DetectForAll : Form
    {
        public static int con = 0, disCon = 0;
        public event handlerDele timerRestart;
        public DetectForAll()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void changeStatus(bool status) {
            if (status)
            {
                this.status.Text = "已连接";
                this.status.ForeColor = Color.Green;
                retryBtn.Visible = false;
            }
            else
            {
                this.status.Text = "已断开";
                this.status.ForeColor = Color.Red;
                retryBtn.Visible = true;
            }
        
        }

        public void fresh() {
            label1.Text = v.IpAddress+":"+v.IpPort;
            if (v.OnConnect)
            {
                this.status.Text = "已连接";
                this.status.ForeColor = Color.Green;
                retryBtn.Visible = false;
            }
            else
            {
                this.status.Text = "已断开";
                this.status.ForeColor = Color.Red;
                retryBtn.Visible = true;
            }
        }

        public void invalidate() {
            btnCon.Text = con.ToString();
            btnDCon.Text = disCon.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sysTime.Text = DateTime.Now.ToString();
        }

        private void retryBtn_Click(object sender, EventArgs e)
        {
            if (DetectMain.testConnection())
                timerRestart();
            else
                MessageBox.Show("还是连不上。");
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_2s.Checked)
                MainWindow.timer.Interval = 2000;
            else if (radioButton_5s.Checked)
                MainWindow.timer.Interval = 5000;
            else if (radioButton_10s.Checked)
                MainWindow.timer.Interval = 10000;
        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void sysTime_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.invalidate();
        }
    }
}
