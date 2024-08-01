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
    public delegate void refreshTCDelegate();//发送方的委托声明，这玩意儿在类外部
    public partial class Settings : UserControl
    {

       

        public event refreshTCDelegate refreshTCEvent;//发送方的调用接口
        public Settings()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sysTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sysTime.Text = DateTime.Now.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text.Equals("修改")) {
                btn1.Text = "保存";
                t2.Enabled = true;
                t1.Enabled = true;
                ipStatus.ForeColor = Color.DarkRed;
                ipStatus.Text = "未连接";
                ipLabel.Text = "--/--";
                listBox1.Items.Add(DateTime.Now.ToString() + ": 服务器已断开");
                listBox1.Items.Add(DateTime.Now.ToString() + ": 数据库已断开");

            }
            else
            {
                btn1.Text = "修改";
                t1.Enabled = false;
                t2.Enabled = false;
                ipStatus.ForeColor = Color.DarkGreen;
                ipStatus.Text = "连接成功";
                ipLabel.Text = t1.Text;
                listBox1.Items.Add(DateTime.Now.ToString() + ": 连接至" + t1.Text + ":" + t2.Text);
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text.Equals("修改")){
                btn2.Text = "保存";
                t3.Enabled = true;
                t4.Enabled = true;
                t5.Enabled = true;
                listBox1.Items.Add(DateTime.Now.ToString() + ": 数据库已断开");

            }
            else
            {
                btn2.Text = "修改";
                t3.Enabled = false;
                t4.Enabled = false;
                t5.Enabled = false;
                listBox1.Items.Add(DateTime.Now.ToString() + ": 已连接数据库");

            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            SaveServerData.fromServer("s");
            t6.Text = ServerSettings.AlertSec.ToString();
            t7.Text = ServerSettings.AlertLevel.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {
                if (Int32.Parse(t6.Text) > 1 && Double.Parse(t7.Text) > 0)
                {
                    listBox1.Items.Add(DateTime.Now.ToString() + ": 更改预警参数，" + t6.Text + "秒，" + t7.Text + "kg");
                    
                    ServerSettings.AlertSec = Int32.Parse(t6.Text);
                    ServerSettings.AlertLevel = Double.Parse(t7.Text);
                    SaveServerData.toServer("J");
                    v.serverSettingsUpdate();
                }
                else {
                    MessageBox.Show("输入错误1！");
                }
            } catch {
                MessageBox.Show("输入错误2！");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(DateTime.Now.ToString() + ": 已导出10分钟内终端采集数据,位置E:/test/exportData.xls.");
            string path = @"E:\\test\\exportData.xls";
            DataSet ds = new DataSet();
            ds.Tables.Add(TrailContainer.getDataTableIn300());
            Excel.WriteExcel(ds, path);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(DateTime.Now.ToString() + ": 更改终端采集间隔为" + comboBox2.Text);
            MessageBox.Show("操作成功");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(DateTime.Now.ToString() + ": 所有终端数据已置零");
            SaveServerData.toServer("opmA");
            MessageBox.Show("操作成功");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private  void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();          //先调用基类实现

            if (e.Index < 0)            //form load 的时候return
                return;

            //因为此函数每一个 listItem drawing 都要调用， 所以不能简单的只写e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),e.Font, Brushes.Red, e.Bounds);
            //那样会造成所有item一个颜色
            //这里是用item字符串是否包含某些词决定的 ， 不好
            if (listBox1.Items[e.Index].ToString().Contains("断开"))
            {
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
                e.Font, Brushes.Red, e.Bounds);
            }
            else if (listBox1.Items[e.Index].ToString().Contains("连接"))
            {
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
                    e.Font, Brushes.DarkGreen, e.Bounds);

            }
            else if (listBox1.Items[e.Index].ToString().Contains("间隔"))
            {
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(),
                    e.Font, Brushes.DarkViolet, e.Bounds) ;

            }
            else
            {
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                        e.Font, Brushes.Black, e.Bounds);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(DateTime.Now.ToString() + ": 已将" + comboBox1.Text.Substring(2)+"号传感器数据置零");
            SaveServerData.toServer("opm"+ comboBox1.Text.Substring(2));
            MessageBox.Show("操作成功" + comboBox1.Text);
        }
    }
}
