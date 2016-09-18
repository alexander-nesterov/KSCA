using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KSCA;

namespace Example1
{
    class Program
    {
        static KSCA_Proxy proxy;
        static void Main()
        {
            proxy = new KSCA_Proxy("localhost", 13291, true);

            proxy.ConnectToProxy();

            Console.WriteLine(String.Format("Build: {0}", proxy.GetBuild()));
            Console.WriteLine(String.Format("VersionID: {0}", proxy.GetVersionID()));

            proxy.Disconnect();

            Console.ReadKey();
        }
    }
}
