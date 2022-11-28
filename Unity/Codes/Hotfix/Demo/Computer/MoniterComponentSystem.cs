using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class MoniterComponentSystem
    {
        public static void Display(this MonitorComponent self)
        {
            if (self != null)
                Log.Debug("Moniters start display!!!");
        }
    }
}