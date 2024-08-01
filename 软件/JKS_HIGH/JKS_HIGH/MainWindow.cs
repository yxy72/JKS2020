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
   


    public partial class MainWindow : Form
    {
        private DetectMain detectMain = new DetectMain();
        private ProgressPage progressPage = new ProgressPage();
        private int sort = 0;
        
        private TrailStatus trailStatus = new TrailStatus();
        private Settings settings = new Settings();
        private TrailContainer trailContainer = new TrailContainer(); 

        public static Timer timer = new Timer();
        private static int ScreenHeight;
        private static int ScreenWidth;//MainWindow's Panel1

        public MainWindow()
        {
            InitializeComponent();
            // SaveServerData.Save("p");
            // Console.WriteLine(PTInfo.Data[1]);
            timer = timer1;
            ScreenHeight = Height;
            Console.WriteLine(ScreenHeight);
            ScreenWidth = MAIN.Width;
        }



        private void mainBtn_AllSHow_Click(object sender, EventArgs e)
        {
           
            if (sort != 1) { 
                sort = 1;
                MAIN.Controls.Clear();
                detectMain.TopLevel = false;
                MAIN.Controls.Add(detectMain); 
                detectMain.Show(); 

            }

           
        }

        private void mainBtn_Data_Click(object sender, EventArgs e)
        {
            
            if (sort != 2)
            {
                sort = 2;
               /* MAIN.Controls.Clear();

                MAIN.Controls.Add(trailStatus);
                trailStatus.Location = new Point(-10, Height - trailStatus.Height );

               trailStatus.Show();

                MAIN.Controls.Add(trial);
                trial.Show();
               */
               
                MAIN.Controls.Clear();
                MAIN.Controls.Add(trailContainer);
                trailContainer.Show();
                //trailContainer.serverSettingsUpdate();

            }
        }
        private void mainBtn_About_Click(object sender, EventArgs e)
        {
            if (sort != 3)
            {
                sort = 3;
                MAIN.Controls.Clear();
                MAIN.Controls.Add(settings);
                settings.Show();

            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!v.testConnection())
            {
                timer1.Stop();
                v.OnConnect = false;
                MessageBox.Show("与服务器断开连接！");
                return;
            }
            else
            {
                SaveServerData.fromServer("p");
                v.OnConnect = true;


            }






        } 


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

       
        private void mainBtn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
