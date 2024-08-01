using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace JKS_HIGH
{
    class ServerData
    {
        public static string getDataFromServer(string send)
        {
            try
            {
                int port = v.IpPort;
                string host = v.IpAddress;
                IPAddress ip = IPAddress.Parse(host);
                IPEndPoint ipe = new IPEndPoint(ip, port);//把ip和端口转化为IPEndpoint实例  

                Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建Socket  
                c.Connect(ipe);//连接到服务器  

                string sendStr = send;
                byte[] bs = Encoding.ASCII.GetBytes(sendStr);//把字符串编码为字节  
                c.Send(bs, bs.Length, 0);//发送信息  


                string recvStr = "";
                byte[] recvBytes = new byte[2048];
                int bytes;
                bytes = c.Receive(recvBytes, recvBytes.Length, 0);//从服务器端接受返回信息  
                recvStr += Encoding.ASCII.GetString(recvBytes, 0, bytes);
                c.Close();
                return recvStr;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("argumentNullException: {0}");
            }
            catch (SocketException)
            {
                Console.WriteLine("SocketException:{0}");
            }
            return "serverErr";
        }

    }

}
