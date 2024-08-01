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
    public delegate void Event();
    public partial class DetectForDetail : Form
    {

        public event Event handler1;
        
        public DetectForDetail()
        {
            InitializeComponent();
        }
        public void invalidate(int which)
        {

            //DetectMain.saveDataFromServer("p");
            detail_n.Text = "传感器" + which.ToString();
            if (which < 10)
                detail_sort.Text = "PT0" + which.ToString();
            else
                detail_sort.Text = "PT" + which.ToString();
            detail_d.Text = PTInfo.Data[which];
            if (PTInfo.Status[which]==0)
            {
                detail_status.ForeColor = System.Drawing.Color.Red;
                detail_status.Text = "已断开";
            }
            else if (PTInfo.Status[which] == 1)
            {
                detail_status.ForeColor = System.Drawing.Color.Green;
                detail_status.Text = "运行中";
            }
            else if (PTInfo.Status[which] == 2)
            {
                detail_status.ForeColor = System.Drawing.Color.Gray;
                detail_status.Text = "未安装";
            }

        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
        private void btnReturn_Click(object sender, EventArgs e)
        {
            handler1();
        }

        private void detail_status_Click(object sender, EventArgs e)
        {

        }
    }
}
