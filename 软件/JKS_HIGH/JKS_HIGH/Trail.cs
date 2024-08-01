using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace JKS_HIGH
{
    public partial class Trail : UserControl
    {
        private bool dragPermit = false;
        private Point clickPoint;
        private static int WIDTH, HEIGHT;
        private static int ScreenHeight;
        private static int AreaWidth = 1688;//MainWindow's Panel1

        private static int PTwidth, PTheight;
        private static PT[] pt = new PT[PTInfo.PTnum - 1];

        private static int testNum = 0;

        private static double _FixValue;
        private static double _CalValue;
        private TrailStatus trailStatus = new TrailStatus();

        #region allTest

        private static double btnWIDTH, btnHEIGHT;
        private static double FONTSIZE;
        private static double proportion;
        

        //private static string Sdata;
        //private static double Ddata;
        //private static double RadiusScaleLevel;
        private static double RadiusFactLevel;
        private static int AlphaLevel;
        private static Point GraphicsLocation;

        private Bitmap SetPictureAlpha(Image image, int alpha)
        {
            //颜色矩阵  
            float[][] matrixItems =
            {
               new float[]{1,0,0,0,0},
               new float[]{0,1,0,0,0},
               new float[]{0,0,1,0,0},
               new float[]{0,0,0,alpha/255f,0},
               new float[]{0,0,0,0,1}
           };
            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);
            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAtt);
            g.Dispose();

            return bmp;
        }

        


        public static void Init()
        {
           



            btnWIDTH = v.ptImgWidth;
            btnHEIGHT = v.ptImgHeight;
            proportion = (v.ScaleLevel / v.ScaleStandard);
        }

        private static void GraphicsRefresh(int sort,int Cx,int Cy) {
            string Sdata = PTInfo.Data[sort];
            double Ddata = Double.Parse(Sdata);
            double RadiusScaleLevel = Ddata / v.MaxAlertLevel;
            RadiusFactLevel = v.MaxAlertRadius * RadiusScaleLevel;

            AlphaLevel = (255 * RadiusScaleLevel) > 255 ? 255: (int)(255 * RadiusScaleLevel);

            double  Lx, Ly;
            Lx = (Cx + btnWIDTH / 2) - RadiusFactLevel;
            Ly = (Cy + btnHEIGHT/ 2) - RadiusFactLevel;

            GraphicsLocation = new Point((int)Lx,(int)Ly);


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //e.Graphics.DrawImage(Properties.Resources.p1, 1, 1);
            Font font = new Font("微软雅黑", (float)(v.TextSize * proportion));

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 4; j++)
                {


                    int sort = PTInfo.RealSort[i * 4 + j];
                    e.Graphics.DrawString("  PT" + sort.ToString(), font, Brushes.Black, (int)(v.PTLocationX[j] * proportion), (int)(v.pTLocationY2[i] * proportion));


                    if (PTInfo.Status[sort] == 0)
                    {
                        e.Graphics.DrawImage(Properties.Resources.iconMain2_96px, (int)(v.PTLocationX[j] * proportion), (int)(v.PTLocationY[i] * proportion), (int)(btnWIDTH * proportion), (int)(btnWIDTH * proportion));
                        e.Graphics.DrawString("已断开", font, Brushes.Red, (int)(v.PTLocationX[j] * proportion), (int)(v.pTLocationY3[i] * proportion));

                    }
                    else if (PTInfo.Status[sort] == 1)
                    {
                        GraphicsRefresh(sort, v.PTLocationX[j], v.PTLocationY[i]);


                       
                        e.Graphics.DrawImage(SetPictureAlpha(Properties.Resources.p1, AlphaLevel), (int)(GraphicsLocation.X * proportion), (int)(GraphicsLocation.Y * proportion), (float)(RadiusFactLevel * 2 * proportion), (float)(RadiusFactLevel * 2 * proportion));
                        e.Graphics.DrawImage(Properties.Resources.iconMain_96px, (int)(v.PTLocationX[j] * proportion), (int)(v.PTLocationY[i] * proportion), (int)(btnWIDTH * proportion), (int)(btnWIDTH * proportion));
                        e.Graphics.DrawString(PTInfo.Data[sort] + " kg", font, Brushes.DarkGreen, (int)(v.PTLocationX[j] * proportion), (int)(v.pTLocationY3[i] * proportion));

                    }
                    else if (PTInfo.Status[sort] == 2)
                    {
                        e.Graphics.DrawImage(Properties.Resources.iconMain2_96px, (int)(v.PTLocationX[j] * proportion), (int)(v.PTLocationY[i] * proportion), (int)(btnWIDTH * proportion), (int)(btnWIDTH * proportion));
                        e.Graphics.DrawString("未安装", font, Brushes.Gray, (int)(v.PTLocationX[j] * proportion), (int)(v.pTLocationY3[i] * proportion));


                    }








                }



            //data.Font = sort.Font = new Font("微软雅黑", (float)(FONTSIZE * proportion));




        }












        #endregion









        private void UserControl1_Load(object sender, EventArgs e)
        {
            /*
            
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 4; j++)
                {
                    pt[i * 4 + j] = new PT(v.PTLocationX[j], v.PTLocationY[i], i * 4 + j);
                    this.Controls.Add(pt[i * 4 + j]);
                }
            PtInvalidate();
            */

            
            Init();


        }
        private static float X, Y;
        private static bool b = false;

        public static int AreaWidth1 { get => AreaWidth; set => AreaWidth = value; }

        public Trail()
        {
            InitializeComponent();
           

            X = this.Width;
            Y = this.Height;
            SetTag(this);
            b = true;

            WIDTH = Width;
            HEIGHT = Height;
            ScreenHeight = Screen.GetWorkingArea(this).Height;

            _FixValue = (ScreenHeight - HEIGHT * v.MinLevel / v.ScaleStandard);
            _CalValue = _FixValue - ScreenHeight;

            //Console.WriteLine(Enum.GetName(SORT.Mon.GetType(),SORT.Mon));



           



            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲


        }


        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            dragPermit = true;
            clickPoint = new Point(e.X, e.Y);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            dragPermit = false;
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (!dragPermit)
                return;
            int OffsetX = e.X - clickPoint.X;
            int OffsetY = e.Y - clickPoint.Y;
          

            
            if( 0>=this.Location.Y + OffsetY && this.Location.Y + OffsetY >= -(HEIGHT * v.ScaleLevel /v.ScaleStandard + _CalValue))
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + OffsetY);

            
            if((this.Location.X +OffsetX <=0 && this.Location.X + OffsetX >= AreaWidth- Width) || (this.Location.X + OffsetX >= 0 && this.Location.X + OffsetX <= AreaWidth - Width))//Width * ScaleLevel / ScaleStandard
                this.Location = new System.Drawing.Point(this.Location.X+OffsetX, this.Location.Y);
           


        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            if (e.Delta > 0) {
                if (v.ScaleLevel < v.MaxLevel)
                    v.ScaleLevel += 2;
            }
            else
            {
                if (v.ScaleLevel > v.MinLevel)
                    v.ScaleLevel -=2;
            }

            proportion = (v.ScaleLevel / v.ScaleStandard);

            this.Width = (int)(WIDTH * proportion);
            this.Height = (int)(HEIGHT * proportion);

            

            if (this.Location.Y + Height < ScreenHeight)
                this.Location = new System.Drawing.Point(this.Location.X, ScreenHeight - Height - (int)_FixValue);
           
            if (this.Location.X >0 && this.Location.X + Width > AreaWidth)
                this.Location = new System.Drawing.Point(AreaWidth - Width, Location.Y);
            else if (this.Location.X < 0 && this.Location.X + Width < AreaWidth)
                this.Location = new System.Drawing.Point(AreaWidth - Width, Location.Y);

           // for (int i = 0; i < 6; i++)
                //for (int j = 0; j < 4; j++)
                 //   pt[i * 4 + j].changeSize(v.ScaleLevel / v.ScaleStandard);

        }


        /// <summary>
        /// 存储原始控件参数
        /// </summary>
        /// <param name="cons"></param>
        private void SetTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    SetTag(con);
            }
        }

        


        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void PtInvalidate() {
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 4; j++)
                    pt[i * 4 + j].Invalidate(new Rectangle(0,0,new PT().Width, new PT().Height));
        }

    }
}

