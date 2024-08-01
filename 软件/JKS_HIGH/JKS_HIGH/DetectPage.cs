using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKS_HIGH
{
    public delegate void handlerDeleForUpdate(int which);
    public delegate void handlerDele();
    public partial class DetectPage : Form
    {
        
        //114.215.181.67
       
        private static Label[] labelData = new Label[PTInfo.PTnum];
        private static Label[] labelStatus = new Label[PTInfo.PTnum];
        private static Button[] btnAll = new Button[PTInfo.PTnum];

        //委托
        public event handlerDeleForUpdate handleForUpdate;
        public event handlerDele handlerForPageChange;






        public void invalidate() {
            //DetectMain.saveDataFromServer("p");
            upDateData();
        }

        private void upDateData() {
           
            
            int con = 0, disCon = 0;

            for (int i = 1; i < PTInfo.PTnum; i++) {
                
                    
                
                if (PTInfo.Status[i] == 0){
                    labelStatus[i].ForeColor = System.Drawing.Color.Red;
                    labelStatus[i].Text = "已断开";
                    labelData[i].Text = "00.00 kg";
                    btnAll[i].Image = Properties.Resources.iconMain2_96px;
                    labelData[i].ForeColor = System.Drawing.Color.Black;
                    disCon++;
                } else if (PTInfo.Status[i] == 1)
                {
                    labelStatus[i].ForeColor = System.Drawing.Color.Green;
                    labelStatus[i].Text = "运行中";
                    labelData[i].Text = PTInfo.Data[i] + " kg";
                    btnAll[i].Image = Properties.Resources.iconMain_96px;
                    labelData[i].ForeColor = System.Drawing.Color.Black;

                    con++;
                }else if (PTInfo.Status[i] == 2)
                {
                    labelStatus[i].ForeColor = System.Drawing.Color.Gray;
                    labelStatus[i].Text = "未安装";
                    btnAll[i].Image = Properties.Resources.iconMain2_96px;
                    labelData[i].Text = "--";
                    labelData[i].ForeColor = System.Drawing.Color.Gray;
                    disCon++;
                }


            }

            /*/仅制图有以下代码：
            btnAll[1].Image = Properties.Resources.iconMain_96px;
            labelStatus[1].ForeColor = System.Drawing.Color.Green;
            labelData[1].Text = "82.66 kg";
            labelStatus[1].Text = "运行中";
            //仅毕*/

            DetectForAll.con = con;
            DetectForAll.disCon = disCon;

        }

       




        private void locateInti()
        {
            labelData[1] = a1_d;
            labelData[2] = a2_d;
            labelData[3] = a3_d;
            labelData[4] = a4_d;
            labelData[5] = a5_d;
            labelData[6] = a6_d;
            labelData[7] = a7_d;
            labelData[8] = a8_d;
            labelData[9] = a9_d;
            labelData[10] = a10_d;
            labelData[11] = a11_d;
            labelData[12] = a12_d;
            labelData[13] = a13_d;
            labelData[14] = a14_d;
            labelData[15] = a15_d;
            labelData[16] = a16_d;
            labelData[17] = a17_d;
            labelData[18] = a18_d;
            labelData[19] = a19_d;
            labelData[20] = a20_d;
            labelData[21] = a21_d;
            labelData[22] = a22_d;
            labelData[23] = a23_d;
            labelData[24] = a24_d;

            labelStatus[1] = a1_s;
            labelStatus[2] = a2_s;
            labelStatus[3] = a3_s;
            labelStatus[4] = a4_s;
            labelStatus[5] = a5_s;
            labelStatus[6] = a6_s;
            labelStatus[7] = a7_s;
            labelStatus[8] = a8_s;
            labelStatus[9] = a9_s;
            labelStatus[10] = a10_s;
            labelStatus[11] = a11_s;
            labelStatus[12] = a12_s;
            labelStatus[13] = a13_s;
            labelStatus[14] = a14_s;
            labelStatus[15] = a15_s;
            labelStatus[16] = a16_s;
            labelStatus[17] = a17_s;
            labelStatus[18] = a18_s;
            labelStatus[19] = a19_s;
            labelStatus[20] = a20_s;
            labelStatus[21] = a21_s;
            labelStatus[22] = a22_s;
            labelStatus[23] = a23_s;
            labelStatus[24] = a24_s;

            btnAll[1] = a1_b;
            btnAll[2] = a2_b;
            btnAll[3] = a3_b;
            btnAll[4] = a4_b;
            btnAll[5] = a5_b;
            btnAll[6] = a6_b;
            btnAll[7] = a7_b;
            btnAll[8] = a8_b;
            btnAll[9] = a9_b;
            btnAll[10] = a10_b;
            btnAll[11] = a11_b;
            btnAll[12] = a12_b;
            btnAll[13] = a13_b;
            btnAll[14] = a14_b;
            btnAll[15] = a15_b;
            btnAll[16] = a16_b;
            btnAll[17] = a17_b;
            btnAll[18] = a18_b;
            btnAll[19] = a19_b;
            btnAll[20] = a20_b;
            btnAll[21] = a21_b;
            btnAll[22] = a22_b;
            btnAll[23] = a23_b;
            btnAll[24] = a24_b;




        }
        public DetectPage()
        {
            InitializeComponent();
            locateInti();
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void handler() {
            handlerForPageChange();

    }


    private void a1_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(1);handler();
        }

        private void a2_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(2); handler();
        }

        private void a3_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(3); handler();
        }

        private void a4_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(4); handler();
        }

        private void a5_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(5); handler();
        }

        private void a6_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(6); handler();
        }

        private void a7_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(7); handler();
        }

        private void a8_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(8); handler();
        }

        private void a9_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(9); handler();
        }

        private void a10_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(10); handler();
        }

        private void a11_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(11); handler();
        }

        private void a12_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(12); handler();
        }

        private void a13_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(13); handler();
        }

        private void a14_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(14); handler();
        }

        private void a15_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(15); handler();
        }

        private void a16_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(16); handler();
        }

        private void a17_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(17); handler();
        }

        private void a18_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(18); handler();
        }

        private void a19_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(19); handler();
        }

        private void a20_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(20); handler();
        }

        private void a21_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(21); handler();
        }

        private void a22_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(22); handler();
        }

        private void a23_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(23); handler();
        }

        private void a24_b_Click(object sender, EventArgs e)
        {
            handleForUpdate(24); handler();
        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void a1_d_Click(object sender, EventArgs e)
        {

        }


        /* cs代码备份
    this.a1_b.Click += new System.EventHandler(this.a1_b_Click);
   this.a2_b.Click += new System.EventHandler(this.a2_b_Click);
   this.a3_b.Click += new System.EventHandler(this.a3_b_Click);
   this.a4_b.Click += new System.EventHandler(this.a4_b_Click);
   this.a5_b.Click += new System.EventHandler(this.a5_b_Click);
   this.a6_b.Click += new System.EventHandler(this.a6_b_Click);
   this.a7_b.Click += new System.EventHandler(this.a7_b_Click);
   this.a8_b.Click += new System.EventHandler(this.a8_b_Click);
   this.a9_b.Click += new System.EventHandler(this.a9_b_Click);
   this.a10_b.Click += new System.EventHandler(this.a10_b_Click);
   this.a11_b.Click += new System.EventHandler(this.a11_b_Click);
   this.a12_b.Click += new System.EventHandler(this.a12_b_Click);
   this.a13_b.Click += new System.EventHandler(this.a13_b_Click);
   this.a14_b.Click += new System.EventHandler(this.a14_b_Click);
   this.a15_b.Click += new System.EventHandler(this.a15_b_Click);
   this.a16_b.Click += new System.EventHandler(this.a16_b_Click);
   this.a17_b.Click += new System.EventHandler(this.a17_b_Click);
   this.a18_b.Click += new System.EventHandler(this.a18_b_Click);
   this.a19_b.Click += new System.EventHandler(this.a19_b_Click);
   this.a20_b.Click += new System.EventHandler(this.a20_b_Click);
   this.a21_b.Click += new System.EventHandler(this.a21_b_Click);
   this.a22_b.Click += new System.EventHandler(this.a22_b_Click);
   this.a23_b.Click += new System.EventHandler(this.a23_b_Click);
   this.a24_b.Click += new System.EventHandler(this.a24_b_Click);*/

    }
}
