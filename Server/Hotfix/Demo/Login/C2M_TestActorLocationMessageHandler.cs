using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class C2M_TestActorLocationMessageHandler : AMActorLocationHandler<Unit, C2M_TestActorLocationMessage>
    {
        protected override async ETTask Run(Unit unit, C2M_TestActorLocationMessage message)
        {
            Log.Debug(message.Content);
            MessageHelper.SendToClient(unit, new M2C_TestActorMessage() { Content = "bbbbbbbbbbbbbbbb" });
            await ETTask.CompletedTask;
        }
    }
}