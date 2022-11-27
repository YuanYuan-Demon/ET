using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class ComputerSystem
    {
        public static void Start(this Computer self)
        {
            Log.Debug($"Computer Start!!!");
            self.GetComponent<PCCaseComponent>().StartPower();
            self.GetComponent<MonitorComponent>().Display();
        }
    }
}