using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKS_HIGH
{
    class ServerSettings
    {
        private static bool pTStatusNRZ = false;
        private static double alertLevel = 0;
        private static int alertSec = 0;
        private static int timeCollection = 2;

        public static bool PTStatusNRZ { get => pTStatusNRZ; set => pTStatusNRZ = value; }
        public static int AlertSec { get => alertSec; set => alertSec = value; }
        public static int TimeCollection { get => timeCollection; set => timeCollection = value; }
        public static double AlertLevel { get => alertLevel; set => alertLevel = value; }
    }
}
