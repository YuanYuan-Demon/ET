using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class M2C_TestActorMessageHandler : AMHandler<M2C_TestActorMessage>
    {
        protected override void Run(Session session, M2C_TestActorMessage message)
        {
            Log.Debug(message.Content);
        }
    }
}