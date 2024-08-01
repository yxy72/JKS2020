using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKS_HIGH
{
    class TempHis10
    {
        string[][] his10Data = new string[PTInfo.PTnum][];

        public string[][] His10Data { get => his10Data; set => his10Data = value; }

        public void SaveToInfo()
        {
            PTInfo.His10Data = this.His10Data;
        }


        
    }

}
