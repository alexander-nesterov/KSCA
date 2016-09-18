using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KLAKAUTLib;

namespace KSCA
{
    public class KSCA_Tasks
    {
        private KlAkProxy proxy;
        private KlAkTasks tasks;
        public KSCA_Tasks(KlAkProxy proxy)
        {
            this.proxy = proxy;

            tasks = new KlAkTasks();

            tasks.AdmServer = proxy;
        }

    }
}
