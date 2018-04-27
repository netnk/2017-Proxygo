using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ProxyGo
{
    class code1
    {
        public string get(string host, int port, string username, string passcode)
        {
          
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("ip");
            WebProxy myproxy = new WebProxy("http://" + host + ":" + port, false);
            req.Proxy = myproxy;
            req.Proxy.Credentials = new NetworkCredential(username, passcode);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            using (Stream mystream = res.GetResponseStream())
                {
                    using (StreamReader mystreamreader = new StreamReader(mystream))
                        {
                            string result = mystreamreader.ReadToEnd();
                            return result;
                        }
                 }            
        }
    }
}
