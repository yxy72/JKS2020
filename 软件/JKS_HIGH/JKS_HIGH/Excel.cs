using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace JKS_HIGH
{
    class Excel
    {
        public static void WriteExcel(DataSet ds, string path)
        {
            try
            {
                long totalCount = ds.Tables[0].Rows.Count;
                //Console.WriteLine( "共有: " + totalCount + "条数据");
                Thread.Sleep(1000);
                long rowRead = 0;
                float percent = 0;

                StreamWriter sw = new StreamWriter(path, false, Encoding.GetEncoding("gb2312"));
                StringBuilder sb = new StringBuilder();
                for (int k = 0; k < ds.Tables[0].Columns.Count; k++)
                {
                    sb.Append(ds.Tables[0].Columns[k].ColumnName.ToString() + "\t");
                }
                sb.Append(Environment.NewLine);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    rowRead++;
                    percent = ((float)(100 * rowRead)) / totalCount;
                    //  Pbar.Maximum = (int)totalCount;
                    //  Pbar.Value = (int)rowRead;
                    //Console.WriteLine("\r\n" + "正在写入[" + percent.ToString("0.00") + "%]...的数据");
                    System.Windows.Forms.Application.DoEvents();

                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        sb.Append(ds.Tables[0].Rows[i][j].ToString() + "\t");
                    }
                    sb.Append(Environment.NewLine);
                }
                sw.Write(sb.ToString());
                sw.Flush();
                sw.Close();
                MessageBox.Show("已经生成指定Excel文件!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
