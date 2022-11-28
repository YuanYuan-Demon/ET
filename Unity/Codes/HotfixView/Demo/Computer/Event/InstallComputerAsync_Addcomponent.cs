using ET.EventType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class InstallComputerAsync_Addcomponent : AEventAsync<InstallComputerAsync>
    {
        protected override async ETTask Run(InstallComputerAsync arg)
        {
            Log.Debug("aaaaaaaaaaaaaaaaaaaaaaaaaaa");
            await TimerComponent.Instance.WaitAsync(100);
            var computer = arg.Computer;
            computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorComponent>();
            computer.AddComponent<MouseComponent>();
            computer.AddComponent<KeyboardComponent>();
            Log.Debug("bbbbbbbbbbbbbbbbbbbbbbbbbbb");
        }
    }
}