using System.Threading.Tasks;

namespace ET
{
    [MessageHandler]
    public class C2R_SayHelloHandler : AMHandler<C2R_SayHello>
    {
        protected override async void Run(Session session, C2R_SayHello message)
        {
            Log.Debug(message.hello);
            session.Send(new R2C_SayGoodbye() { goodbye = $"Goodbye Client" });
            await Task.CompletedTask;
        }
    }
}