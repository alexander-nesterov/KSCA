using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KLAKAUTLib;

namespace KSCA
{
    public class KSCA_Proxy
    {
        private String Address;
        private Int32 Port;
        private Boolean SSL;
        private KlAkProxy proxy;

        public KSCA_Proxy(string Address, int Port, bool SSL)
        {
            this.Address = Address;
            this.Port = Port;
            this.SSL = SSL;
        }

        public void ConnectToProxy()
        {
            proxy = new KlAkProxy();

            proxy.Connect(SetParams(Address, Port, SSL));

        }

        public void Disconnect()
        {
            proxy.Disconnect();
        }

        private KlAkParams SetParams(String Address, Int32 Port, Boolean SSL)
        {
            KlAkParams par = new KlAkParams();

            par.Add("Address", Address + ":" + Port);
            par.Add("UseSSL", SSL);

            return par;
        }

        public String GetBuild()
        {
            return proxy.Build;
        }

        public Int32 GetVersionID()
        {
            return proxy.VersionId;
        }
    }
}
