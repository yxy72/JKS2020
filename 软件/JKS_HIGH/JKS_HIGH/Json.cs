using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JKS_HIGH
{
    class Json
    {
        public static String toJsonStr(object o)
        {
            string rst = JsonConvert.SerializeObject(o);
            return rst;
        }

        public static object toTempStatus(string s)
        {
            return JsonConvert.DeserializeObject<TempStatus>(s);
        }

        public static object toTempHis10(string s)
        {
            return JsonConvert.DeserializeObject<TempHis10>(s);
        }

        public static object toTempSeverSettings(string s)
        {
            return JsonConvert.DeserializeObject<TempServerSettings>(s);
        }

    }
}
