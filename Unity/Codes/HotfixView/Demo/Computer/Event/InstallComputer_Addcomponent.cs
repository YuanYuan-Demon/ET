using ET.EventType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class InstallComputer_Addcomponent : AEvent<InstallComputer>
    {
        protected override void Run(InstallComputer arg)
        {
            var computer = arg.Computer;
            computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorComponent>();
            computer.AddComponent<MouseComponent>();
            computer.AddComponent<KeyboardComponent>();
        }
    }
}