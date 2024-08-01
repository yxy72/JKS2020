using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKS_HIGH
{
    class v
    {
        private const String IP1 = "114.215.181.67";
        private const String IP0 = "127.0.0.1"; //测试用
        private const string ipAddress = IP0;
        private const int ipPort = 3333;

        private const double scaleStandard = 30;
        private const double maxLevel = scaleStandard;
        private static double scaleLevel = scaleStandard;
        private const double minLevel = 8;

        private static int[] pTLocationX = new int[4];
        private static int[] pTLocationY = new int[6];

        private static double maxAlertLevel = 30.00;
        private static double maxAlertRadiusLevel = 225;

        private static bool severOnConnect = false;
        private static int sqlUserAverageTimeCount = 15;//30s
        public static int LAYOUTMODEL;


        private static bool onConnect = false;
        public static bool testConnection() {
            try
            {
                new TcpClient(v.IpAddress, v.IpPort).Close();
                onConnect = true;
                return true;
            }
            catch
            {
                onConnect = false;
                return false;
            }
        }


        #region allTest
        public static int ptImgWidth = 96, ptImgHeight = 96;
        public static int[] pTLocationY2 = new int[6];
        public static int[] pTLocationY3 = new int[6];
        public static int TextSize = 18;
        #endregion
        public static void serverSettingsUpdate()
        {
            SqlUserAverageTimeCount = ServerSettings.AlertSec/2;
            MaxAlertLevel = ServerSettings.AlertLevel;
        }

        public static void PTLocationInit() {
           
            PTLocationX[0] = 333 - ptImgWidth / 2; PTLocationX[1] = 666 - ptImgWidth / 2; PTLocationX[2] = 1733 - ptImgWidth / 2; PTLocationX[3] = 2066 - ptImgWidth / 2;

            double jiange = 4000 / 7.0;
            double y0 = (jiange - ptImgHeight / 2);
            PTLocationY[0] = (int)y0;
            pTLocationY2[0] = PTLocationY[0] + (int)(1.1 * ptImgHeight);
            pTLocationY3[0] = (int)(pTLocationY2[0] + 2 * TextSize);

            for (int i = 1; i < 6; i++)
            {
                PTLocationY[i] = (int)(y0 + i * jiange);
                pTLocationY2[i] = PTLocationY[i] + (int)(1.1*ptImgHeight);
                pTLocationY3[i] = (int)(pTLocationY2[i] + 2 * TextSize);
            }

        }

        public static double MinLevel => minLevel;

        public static double ScaleStandard => scaleStandard;

        public static double MaxLevel => maxLevel;

        public static string IpAddress1 => IpAddress;

        public static string IpAddress => ipAddress;

        public static int IpPort => ipPort;

        public static int[] PTLocationX { get => pTLocationX; set => pTLocationX = value; }
        public static int[] PTLocationY { get => pTLocationY; set => pTLocationY = value; }
        public static bool OnConnect { get => onConnect; set => onConnect = value; }
        public static double ScaleLevel { get => scaleLevel; set => scaleLevel = value; }
        public static double MaxAlertLevel { get => maxAlertLevel; set => maxAlertLevel = value; }
        public static double MaxAlertRadius { get => maxAlertRadiusLevel; set => maxAlertRadiusLevel = value; }
        public static bool SeverOnConnect { get => severOnConnect; set => severOnConnect = value; }
        public static int SqlUserAverageTimeCount { get => sqlUserAverageTimeCount; set => sqlUserAverageTimeCount = value; }
    }
}
