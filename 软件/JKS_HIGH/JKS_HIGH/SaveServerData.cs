using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKS_HIGH
{
    class SaveServerData
    {
        public static void fromServer(string plainText)
        {
            string getContentFromServer = ServerData.getDataFromServer(plainText +"\n");

            if (getContentFromServer.Equals("serverErr"))
                return;
           
            switch (plainText)
            {
                case "p":
                    ((TempStatus)Json.toTempStatus(getContentFromServer)).SaveToInfo();
                    break;
                case "h":
                    ((TempHis10)Json.toTempHis10(getContentFromServer)).SaveToInfo();
                    break;
                case "s":
                    ((TempServerSettings)Json.toTempSeverSettings(getContentFromServer)).SaveToSettings();
                    break;
            }
        }

        public static void toServer(string plainText) {
            
            switch (plainText)
            {
                case "J":

                    string sendJson = Json.toJsonStr(new TempServerSettings());


                    string getContentFromServer = ServerData.getDataFromServer("J" + sendJson + "\n");

                  

                    break;
                default:
                    ServerData.getDataFromServer(plainText + "\n");break;
            }
        }


        public static void fromDataBase(int orderKind) {
            switch (orderKind)
            {
                case 0: 
                    MySQL.saveAllData();
                    break;
                case 1:
                    MySQL.CalculateAverageData();
                    break;
            }
        }
    }
}