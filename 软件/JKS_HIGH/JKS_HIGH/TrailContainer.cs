using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace JKS_HIGH
{
    public partial class TrailContainer : UserControl
    {
        private static Trail trial = new Trail();
        private static TrailBar trailBar = new TrailBar();

        private static string[] Average_5min = new string[PTInfo.LayoutPTNum];
        private static string[] Average_1min = new string[PTInfo.LayoutPTNum];
        private static string[] Average_30s = new string[PTInfo.LayoutPTNum];

        private static string[] alertText1 = new string[4];
        private static int alertLevel1 = new int();


        public static string[] Average1_5min { get => Average_5min; set => Average_5min = value; }
        public static string[] Average1_1min { get => Average_1min; set => Average_1min = value; }
        public static string[] Average1_30s { get => Average_30s; set => Average_30s = value; }

        public TrailContainer()
        {
            InitializeComponent();
            alertText1[0] = "防护区段双侧轨旁传感器报警，轨道大概率无法正常通行！";
            alertText1[1] = "防护区段单侧轨旁传感器报警，有可能危及列车正常行驶！";
            alertText1[2] = "防护区段外侧部分传感器报警，滑坡区域有扩散风险。";
            alertText1[3] = "防护区段未达到警报水平。";
            alertLevel1 = 3;

            for (int i = 1; i < PTInfo.LayoutPTNum; i++) {
                Average_5min[i] = "0";
                Average_1min[i] = "0";
                Average_30s[i] = "0";

            }
        }

        private void TrailContainer_Load(object sender, EventArgs e)
        {
            page.Panel1.Controls.Clear();
            page.SplitterDistance = 640;
            page.Panel1.Controls.Add(trial);
            trial.Show();

            MAIN.Panel2.Controls.Clear();
            MAIN.Panel2.Controls.Add(trailBar); 
            trailBar.Show();

            chartE15.Series[0].Label = "#VAL";
            chartE150.Series[0].Label = "#VAL";
            chartE30.Series[0].Label = "#VAL";
            
            //-----
                SaveServerData.fromServer("s");
                serverSettingsUpdate();
            //-----

            Thread t = new Thread(new ThreadStart(newThreadTimer));
            t.Start();
        }

        public void serverSettingsUpdate() {
            v.serverSettingsUpdate();
            chartE15.Titles[0].Text = "均值_"+ServerSettings.AlertSec+"s";
            trailBar.fresh();

        }

        private static void newThreadTimer() {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 2000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(newThreadTimerTask);
            timer.Enabled = true;

        }
        private static void newThreadTimerTask(object sender, System.Timers.ElapsedEventArgs e) {
            SaveServerData.fromDataBase(0);
            SaveServerData.fromDataBase(1);
        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void page_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Trail.AreaWidth1 = e.SplitX;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          

            DataTable dt = default(DataTable);
            dt = getDataTableIn300();
            chartAll.DataSource = dt;
            chartAll.Series[0].XValueMember = "time";
            chartAll.Series[0].YValueMembers = "dataPT1";
            chartAll.Series[1].YValueMembers = "dataPT2";
            chartAll.Series[2].YValueMembers = "dataPT3";
            chartAll.Series[3].YValueMembers = "dataPT4";
            chartAll.Series[4].YValueMembers = "dataPT5";
            chartAll.Series[5].YValueMembers = "dataPT6";
            chartAll.DataBind();

            dt = getDataTableAverage150();
            chartE150.DataSource = dt;
            chartE150.Series[0].XValueMember = "PTName";
            chartE150.Series[0].YValueMembers = "Average";
            chartE150.DataBind();

            dt = getDataTableAverage30();
            chartE30.DataSource = dt;
            chartE30.Series[0].XValueMember = "PTName";
            chartE30.Series[0].YValueMembers = "Average";
            chartE30.DataBind();

            dt = getDataTableAverage15();
            chartE15.DataSource = dt;
            chartE15.Series[0].XValueMember = "PTName";
            chartE15.Series[0].YValueMembers = "Average";
            chartE15.DataBind();
        }


        private DataTable getDataTableAverage150() {

            string[] PT = new string[PTInfo.LayoutPTNum];
            for (int a = 1; a < PTInfo.LayoutPTNum; a++) 
                PT[a] = "PT"+a.ToString();


            DataTable dt = new DataTable();
            dt.Columns.Add("PTName");
            dt.Columns.Add("Average");

            DataRow dr;
            for (int i = 1; i < PTInfo.LayoutPTNum; i++)
            {
                dr = dt.NewRow();
                dr["PTName"] = PT[i];
                dr["Average"] = Average_5min[i];
                dt.Rows.Add(dr);
            }
            return dt;

        }
        private DataTable getDataTableAverage30()
        {

            string[] PT = new string[PTInfo.LayoutPTNum];
            for (int a = 1; a < PTInfo.LayoutPTNum; a++)
                PT[a] = "PT" + a.ToString();


            DataTable dt = new DataTable();
            dt.Columns.Add("PTName");
            dt.Columns.Add("Average");

            DataRow dr;
            for (int i = 1; i < PTInfo.LayoutPTNum; i++)
            {
                dr = dt.NewRow();
                dr["PTName"] = PT[i];
                dr["Average"] = Average_1min[i];
                dt.Rows.Add(dr);
            }
            return dt;

        }
        private DataTable getDataTableAverage15()
        {

            string[] PT = new string[PTInfo.LayoutPTNum];
            for (int a = 1; a < PTInfo.LayoutPTNum; a++)
                PT[a] = "PT" + a.ToString();


            DataTable dt = new DataTable();
            dt.Columns.Add("PTName");
            dt.Columns.Add("Average");

            DataRow dr;
            for (int i = 1; i < PTInfo.LayoutPTNum; i++)
            {
                dr = dt.NewRow();
                dr["PTName"] = PT[i];
                dr["Average"] = Average_30s[i];
                dt.Rows.Add(dr);
            }
            return dt;

        }

        public static DataTable getDataTableIn300()
        {
            string[] time = new string[PTInfo.MaxRecordNum];
            int i, j;
            for (i = PTInfo.MaxRecordNum - 1 ,  j = 0   ; i >=0; i--,j++) {
                time[i] = DateTime.Now.AddSeconds(-2*j).ToString().Substring(11,8);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("time");
            dt.Columns.Add("dataPT1");
            dt.Columns.Add("dataPT2");
            dt.Columns.Add("dataPT3");
            dt.Columns.Add("dataPT4");
            dt.Columns.Add("dataPT5");
            dt.Columns.Add("dataPT6");

            DataRow dr;
            for ( i = 0; i < PTInfo.MaxRecordNum; i++)
            {
                dr = dt.NewRow();
                dr["time"] = time[i];
                dr["dataPT1"] = PTInfo.HisMaxData[1][i];
                dr["dataPT2"] = PTInfo.HisMaxData[2][i];
                dr["dataPT3"] = PTInfo.HisMaxData[3][i];
                dr["dataPT4"] = PTInfo.HisMaxData[4][i];
                dr["dataPT5"] = PTInfo.HisMaxData[5][i];
                dr["dataPT6"] = PTInfo.HisMaxData[6][i];


                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void page_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartE_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {


            if(v.LAYOUTMODEL==0)
                if (double.Parse(Average_30s[PTInfo.RealSort[1]]) > v.MaxAlertLevel &&
                    double.Parse(Average_30s[PTInfo.RealSort[2]]) > v.MaxAlertLevel &&
                    double.Parse(Average_30s[PTInfo.RealSort[5]]) > v.MaxAlertLevel &&
                    double.Parse(Average_30s[PTInfo.RealSort[6]]) > v.MaxAlertLevel &&
                    double.Parse(Average_30s[PTInfo.RealSort[9]]) > v.MaxAlertLevel &&
                    double.Parse(Average_30s[PTInfo.RealSort[10]]) > v.MaxAlertLevel)
                    alertLevel1 = 0;
                else if (double.Parse(Average_30s[PTInfo.RealSort[2]]) > v.MaxAlertLevel &&
                         double.Parse(Average_30s[PTInfo.RealSort[6]]) > v.MaxAlertLevel &&
                         double.Parse(Average_30s[PTInfo.RealSort[10]]) > v.MaxAlertLevel)
                    alertLevel1 = 1;
                else if (double.Parse(Average_30s[PTInfo.RealSort[1]]) > v.MaxAlertLevel &&
                         double.Parse(Average_30s[PTInfo.RealSort[5]]) > v.MaxAlertLevel &&
                         double.Parse(Average_30s[PTInfo.RealSort[9]]) > v.MaxAlertLevel)
                    alertLevel1 = 1;
                else
                    alertLevel1 = 3;
            else if(v.LAYOUTMODEL==1)
                if (
                    double.Parse(Average_30s[PTInfo.RealSort[2]]) > v.MaxAlertLevel &&
                    double.Parse(Average_30s[PTInfo.RealSort[6]]) > v.MaxAlertLevel &&
                    double.Parse(Average_30s[PTInfo.RealSort[10]]) > v.MaxAlertLevel)
                    alertLevel1 = 1;
                else if (double.Parse(Average_30s[PTInfo.RealSort[3]]) > v.MaxAlertLevel &&
                         double.Parse(Average_30s[PTInfo.RealSort[7]]) > v.MaxAlertLevel &&
                         double.Parse(Average_30s[PTInfo.RealSort[11]]) > v.MaxAlertLevel)
                    alertLevel1 = 2;
                else
                    alertLevel1 = 3;

            switch (alertLevel1) {
                case 0:
                    alertLevel.ForeColor = System.Drawing.Color.Red;
                    alertText.ForeColor = System.Drawing.Color.Red;
                    label2.Text = "级";
                    alertLevel.Text = "1";
                    detailText.Text = "双侧轨旁传感器在报警时间范围内的均值都达到了报警值。";
                    break;
                case 1:
                    alertLevel.ForeColor = System.Drawing.Color.Red;
                    alertText.ForeColor = System.Drawing.Color.Red;
                    label2.Text = "级";
                    alertLevel.Text = "2";
                    detailText.Text = "单侧轨旁传感器在报警时间范围内的均值都达到了报警值。";
                    break;
                case 2:
                    alertLevel.ForeColor = System.Drawing.Color.Red;
                    alertText.ForeColor = System.Drawing.Color.Black;
                    label2.Text = "级";
                    alertLevel.Text = "3";
                    detailText.Text = "外围传感器在报警时间范围内的均值都达到了报警值。";

                    break;
                case 3:
                    alertLevel.ForeColor = System.Drawing.Color.Black;
                    alertText.ForeColor = System.Drawing.Color.Green;
                    label2.Text = "";
                    alertLevel.Text = "--";
                    detailText.Text = "";
                    break;
            }




            alertText.Text = alertText1[alertLevel1];


        }

        private void alertLevel_Click(object sender, EventArgs e)
        {

        }

        private void chartAll_Click(object sender, EventArgs e)
        {

        }

        private void MAIN_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
