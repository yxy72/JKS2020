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
    public partial class PT : UserControl
    {

        private static double WIDTH,HEIGHT;
        private static double btnWIDTH, btnHEIGHT;
        private static double FONTSIZE;
        private int IdentificationSort;


        private Point LOCATION;
        

        public PT(int locationX,int locationY,int sortNum)
        {
            InitializeComponent();

            WIDTH = this.Width;
            HEIGHT = this.Height;
            btnWIDTH = this.btn.Width;
            btnHEIGHT = this.btn.Height;
            FONTSIZE = this.sort.Font.Size;
            LOCATION = this.Location = new Point(locationX,locationY);
            IdentificationSort = sortNum;
            Invalidate();

        }
        public PT()
        {
            InitializeComponent();
        }
        

       

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

           


        }

        private void sort_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click_1(object sender, EventArgs e)
        {

        }

        public void changeSize(double proportion) {
            Width = (int)(WIDTH * proportion);
            Height = (int)(HEIGHT * proportion);

            btn.Width = (int)(btnWIDTH * proportion);
            btn.Height = (int)(btnWIDTH * proportion);

            data.Font = sort.Font = new Font("微软雅黑", (float)(FONTSIZE * proportion));

            Location = new Point((int)(LOCATION.X * proportion), (int)(LOCATION.Y * proportion));


        }



    }
}
