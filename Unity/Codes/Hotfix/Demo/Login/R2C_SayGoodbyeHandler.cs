using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [MessageHandler]
    public class R2C_SayGoodbyeHandler : AMHandler<R2C_SayGoodbye>
    {
        protected override async void Run(Session session, R2C_SayGoodbye message)
        {
            Log.Debug(message.goodbye);
            await Task.CompletedTask;
        }
    }
}