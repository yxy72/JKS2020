using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKS_HIGH
{
    class MySQL
    {
        private static String connetStr = "server=" +v.IpAddress1 + ";port=3306;user=jks2020_root;password=kuaile12345; database=jks2020;";
        //imxp5N5aKTDNtf4y
        private static MySqlConnection connection = new MySqlConnection(connetStr);
        
        private static string[] sqlSelect = new string[6];
      



        public static void Init(){
            
            try
            {
                connection.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
                //在这里使用代码对数据库进行增删查改
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();

            }
            finally
            {
            }

            sqlSelect[0] = "select * from pt1";
            sqlSelect[1] = "select * from pt2";
            sqlSelect[2] = "select * from pt3";
            sqlSelect[3] = "select * from pt4";
            sqlSelect[4] = "select * from pt5";
            sqlSelect[5] = "select * from pt6";

        }
        public static void saveAllData()
        {
            MySqlCommand cmd;
            MySqlDataReader reader;

            for (int sort = 1; sort < PTInfo.LayoutPTNum; sort++) {
                cmd = new MySqlCommand(sqlSelect[sort-1], connection);
                reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    PTInfo.HisMaxData[sort][i++] = reader.GetString("in10");
                }
                reader.Close();
                cmd.Clone();
            }
        }

        public static void CalculateAverageData() {
            MySqlCommand cmd;
            MySqlDataReader reader;
            int maxRecord = PTInfo.MaxRecordNum;
            int cal1 = 150, cal2 = 30, cal3 = v.SqlUserAverageTimeCount;

            for (int sort = 1; sort < PTInfo.LayoutPTNum; sort++)
            {
                cmd = new MySqlCommand(sqlSelect[sort - 1], connection);
                reader = cmd.ExecuteReader();
                
                int i = 0, j = 0, k = 0;
                double data = 0;
                double sum_150times = 0,sum_30times=0,sum_15times=0;

               
                while (reader.Read())
                {
                    data = double.Parse(reader.GetString("in10"));
                    
                    if (i < maxRecord - cal1)
                        i++;
                    else
                        sum_150times += data;

                    if (j< maxRecord - cal2)
                        j++;
                    else sum_30times += data;

                    if (k < maxRecord - cal3)
                        k++;
                    else
                        sum_15times += data;

                }

                TrailContainer.Average1_5min[sort] = decimal.Round(decimal.Parse((sum_150times / cal1).ToString()), 2).ToString();
                TrailContainer.Average1_1min[sort] = decimal.Round(decimal.Parse((sum_30times / cal2).ToString()), 2).ToString();
                TrailContainer.Average1_30s[sort] = decimal.Round(decimal.Parse((sum_15times / cal3).ToString()), 2).ToString();
                
                reader.Close();
                cmd.Clone();
            }
        }
    }
}
