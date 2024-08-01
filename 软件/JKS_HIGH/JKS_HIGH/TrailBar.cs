using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKS_HIGH
{
    public partial class TrailBar : UserControl
    {
        public TrailBar()
        {
            InitializeComponent();
        }

        private void severText_Click(object sender, EventArgs e)
        {

        }

        private void TrailBar_Load(object sender, EventArgs e)
        {
            fresh();
        }

        public void fresh() {
            severText.Text = v.IpAddress;
            label3.Text = ServerSettings.AlertLevel + "kg";
            label5.Text = ServerSettings.AlertSec + "s内";
            severText.Text = v.IpAddress;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sysTime.Text = DateTime.Now.ToString();
            if (v.OnConnect)
            {
                this.severStatus.Text = "已连接";
                this.severStatus.ForeColor = Color.Green;
            }
            else
            {
                this.severStatus.Text = "已断开";
                this.severStatus.ForeColor = Color.Red;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
