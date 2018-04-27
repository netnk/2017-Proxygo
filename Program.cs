using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyGo;

namespace ProxyGo
{
    class Program
    {

        //Framework版本：4
        //Date：2017
        //Proxy連線測試
        //輸入值：ProxyHost、Port、Username、Passcode
        //有result：回傳字串，如可透過Proxy連線，會回傳內容
        //無result：回傳錯誤訊息
        //Proxy測試1：proxy.hinet.net:80 (無帳號密碼)
        //Proxy測試2：proxy.xxx.net:12345 (需帳號密碼)

        static void Main(string[] args)
        {
            ProxyGo.code1 pcc = new ProxyGo.code1();

            try
            {
                Console.WriteLine("Proxy IP: ");
                string host = Console.ReadLine();

                Console.WriteLine("Port:");
                string port0 = Console.ReadLine();
                int port = Int32.Parse(port0);

                Console.WriteLine("Username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Passcode: ");
                string passcode = Console.ReadLine();

                Console.WriteLine("Connecting ... ");
                Console.WriteLine(pcc.get(host, port, username, passcode));
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }

        }
    }
}
