using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JKS_HIGH
{
    public partial class DetectMain : Form
    {
        
        
       
       
        public static string numCon = "none";
        public static string numDC = "none";
        public static int detailSort = 1;

        private bool onConnect = false;

        DetectPage detectPage = new DetectPage();
        DetectForDetail detectForDetail = new DetectForDetail();
        DetectForAll detectForAll = new DetectForAll();



        //DectMain界面 定时器事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!onConnect)
            {
                if (v.OnConnect)
                {
                    onConnect = true;
                    detectForAll.fresh();
                }
                else if(!v.OnConnect)
                {

                }
            }
            else if (onConnect)
            {
                if (!v.OnConnect)
                {
                    onConnect = false;
                    detectForAll.fresh();
                }
                else if(v.OnConnect){ //正常工作
                    detectPage.invalidate();
                    if (tabControl1.SelectedIndex == 1)
                    {
                        detectForDetail.invalidate(detailSort);
                        chartForDetailInvalidate(detailSort);
                    }
                    else
                    {
                        detectForAll.invalidate();
                        chartInvalidate();
                    }
                }
            }



            if (v.OnConnect)
            {
                
                
            }

        }
        //DectMain界面 切换事件
        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
            splitContainer1.Panel2.Controls.Clear();

            if (tabControl1.SelectedIndex == 0)//也可以判断tabControl1.SelectedTab.Text的值
            {
                splitContainer1.Panel2.Controls.Add(detectForAll);
                detectForAll.Show();
                if (!v.OnConnect)
                    return;
                chartInvalidate();
                detectForAll.invalidate();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                splitContainer1.Panel2.Controls.Add(detectForDetail);
                detectForDetail.Show();
                if (!v.OnConnect)
                    return;
                chartForDetailInvalidate(detailSort);
                detectForDetail.invalidate(detailSort);

            }

        }

        private void Inti() {
            //for (int i = 0; i < PTnum; i++)
            //historyDataFor10s[i] = new string[]{ "1","2","3","4","5","6"};
            detectForAll.fresh();
        }
        public DetectMain()
        {
            
            InitializeComponent();
            Inti();
        }

        public static bool testConnection() {

            try {
                new TcpClient(v.IpAddress, v.IpPort).Close();
                v.OnConnect = true;
                return true;
            }
            catch {
                v.OnConnect = false;
                return false; 
            }
        }


        public static void saveDataFromServer(string kind)
        {
            SaveServerData.fromServer(kind);
        }
     

        private void handlerForRestartTimer() {
            detectForAll.changeStatus(v.OnConnect = true);
            MessageBox.Show("连接成功！");
          
        }
        private void DetectMain_Load(object sender, EventArgs e)
        {
       
            if (testConnection())  
                detectPage.invalidate();
           

            detectPage.TopLevel = false;
            PanelShowData.Controls.Add(detectPage);
            detectPage.Show();

            detectForDetail.TopLevel = false;
            detectForAll.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(detectForAll);
            detectForAll.Show();

            


            //绑定事件
            detectPage.handleForUpdate += dealHandler;
            detectPage.handlerForPageChange += dealHandlerForTabChange;
            detectForAll.timerRestart += handlerForRestartTimer;
            detectForDetail.handler1 += dealHandlerForReturnAll;



            chart1.Series[0].Label = "#VAL";
            chart2.Series[0].Label = "#VAL";

            chartInvalidate();


        }

  

      
       

        private Title TitleForChart(int which)
        {
            string temp = "";
            if (which < 10)
                temp = ("传感器PT0" + which.ToString());
            else
                temp = ("传感器PT" + which.ToString());

            Title title = new Title(temp);
            Font fontTitleChart;
            fontTitleChart = new Font("微软雅黑", 12);
            
            title.Font = fontTitleChart;
            return title;
        }

        private void dealHandlerForTabChange() {
            tabControl1.SelectedIndex = 1;
            //Console.WriteLine(tabControl1.TabIndex);
        }
        private void dealHandlerForReturnAll() {
            tabControl1.SelectedIndex = 0;
        }



        //用来接收单个传感器按钮信息台
        void dealHandler(int which)
        {



            //chart信息台
            chart2.Titles.Clear();
            chart2.Titles.Add(TitleForChart(which));


            //detail信息台
            detailSort = which;

            if (v.OnConnect) { 
                detectForDetail.invalidate(which);
                chartForDetailInvalidate(which);
            }

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void chartInvalidate()
        {
            DataTable dt = default(DataTable);
            dt = getDataTable();

            chart1.DataSource = dt;
            chart1.Series[0].YValueMembers = "data";
            chart1.Series[0].XValueMember = "sort";
           
            chart1.DataBind();

        }
        private void chartForDetailInvalidate(int sort) {
            
            
            saveDataFromServer("h");
            DataTable dt = default(DataTable);
            dt = getDataTableDetailIn10s(sort);

            chart2.DataSource = dt;
            chart2.Series[0].YValueMembers = "data";
            chart2.Series[0].XValueMember = "time";

            chart2.DataBind();


        }


        public DataTable getDataTable() {
            DataTable dt = new DataTable();

            dt.Columns.Add("sort");
            dt.Columns.Add("data");

            DataRow dr;
            
            for (int i = 1; i < PTInfo.PTnum; i++) {
                dr = dt.NewRow();
                dr["sort"] = "PT" + i.ToString();
                
                if (PTInfo.Status[i] == 1)
                    dr["data"] = PTInfo.Data[i];
                else
                    dr["data"] = "00.00";


                dt.Rows.Add(dr);
            }
            return dt;
        }
        public DataTable getDataTableTest()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("sort");
            dt.Columns.Add("data");

            DataRow dr;

            for (int i = 1; i < PTInfo.PTnum; i++)
            {
                string temp = PTInfo.Data[i];
                Console.WriteLine(temp);
                dr = dt.NewRow();
                dr["sort"] = "PT" + (i+10).ToString();
                dr["data"] = "1";
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public DataTable getDataTableDetailIn10s(int sort) {

            int[] min = new int[6]; string[] MIN = new string[6];
            int[] sec = new int[6]; string[] SEC = new string[6];
            int[] hour = new int[6]; string[] HOUR = new string[6];

            hour[5] = DateTime.Now.Hour;
            min[5] = DateTime.Now.Minute;
            sec[5] = DateTime.Now.Second;

            int tempFlag;
            if (sec[5] >= 10)
                tempFlag = 0;
            else if (sec[5] >= 8)
                tempFlag = 1;
            else if (sec[5] >= 6)
                tempFlag = 2;
            else if (sec[5] >= 4)
                tempFlag = 3;
            else if (sec[5] >= 2)
                tempFlag = 4;
            else
                tempFlag = 5;

            //处理当前时间及前五个两秒的时间；
            for (int i = 4; i >= tempFlag; i--) {
                hour[i] = hour[5];
                min[i] = min[5];
                sec[i] = sec[i + 1] - 2;
            }
            for (int i = 0; i < tempFlag; i++) { 
                sec[i] = sec[5] - (10 - 2 * i) + 60;
                hour[i] = hour[5];
            }

            for (int i = 0; i < tempFlag; i++)
                if (min[5] >= 1)
                    min[i] = min[5] - 1;
                else { 
                    min[i] = 59;
                    if (hour[5] > 1)
                        hour[i] = hour[5] - 1;
                    else
                        hour[i] = 23;
                }

            for (int i = 0; i < 6; i++) {
                if (hour[i] < 10)
                    HOUR[i] = "0" + hour[i];
                else
                    HOUR[i] = hour[i].ToString();

                if (min[i] < 10)
                    MIN[i] = "0" + min[i];
                else
                    MIN[i] = min[i].ToString();

                if (sec[i] < 10)
                    SEC[i] = "0" + sec[i];
                else
                    SEC[i] = sec[i].ToString();
            }





            DataTable dt = new DataTable();
            dt.Columns.Add("time");
            dt.Columns.Add("data");

            DataRow dr;


           


            for (int i = 0; i < 6; i++) {
                dr = dt.NewRow();
                dr["time"] = HOUR[i]+":"+MIN[i] + ":" + SEC[i];
                dr["data"] = PTInfo.His10Data[sort][i];
                dt.Rows.Add(dr);

            }


            return dt;
        }

        private void PanelShowData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
