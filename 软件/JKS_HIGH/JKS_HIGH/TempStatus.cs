using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKS_HIGH
{
    class TempStatus
    {
        int[] status = new int[PTInfo.PTnum];
        string[] data = new string[PTInfo.PTnum];
        //string[][] his10Data = new string[PTInfo.PTnum][];
        public TempStatus()
        {
        }
        public void SaveToInfo()
        {
            PTInfo.Status = this.status;
            PTInfo.Data = this.data;
        }


        public int[] Status { get => status; set => status = value; }
        public string[] Data { get => data; set => data = value; }
    }
}
