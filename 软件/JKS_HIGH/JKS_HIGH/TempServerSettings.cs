using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKS_HIGH
{
    class TempServerSettings
    {
        private bool pTStatusNRZ;
        private double alertLevel = 0;
        private int alertSec = 0;
        private int timeCollection = 2;

        public TempServerSettings() {
            pTStatusNRZ = ServerSettings.PTStatusNRZ;
            alertLevel = ServerSettings.AlertLevel;
            alertSec = ServerSettings.AlertSec;
            timeCollection = ServerSettings.TimeCollection;
        
        }

        public bool PTStatusNRZ { get => pTStatusNRZ; set => pTStatusNRZ = value; }
        public double AlertLevel { get => alertLevel; set => alertLevel = value; }
        public int AlertSec { get => alertSec; set => alertSec = value; }
        public int TimeCollection { get => timeCollection; set => timeCollection = value; }

        public void SaveToSettings()
        {
            ServerSettings.PTStatusNRZ = this.PTStatusNRZ;
            ServerSettings.AlertLevel = this.AlertLevel;
            ServerSettings.AlertSec = this.AlertSec;
            ServerSettings.TimeCollection = this.TimeCollection;

        }
    }

}
