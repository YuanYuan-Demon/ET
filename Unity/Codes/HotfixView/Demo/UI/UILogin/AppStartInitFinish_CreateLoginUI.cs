using ET.EventType;
using System.Diagnostics;

namespace ET
{
    public class AppStartInitFinish_CreateLoginUI : AEvent<EventType.AppStartInitFinish>
    {
        protected override void Run(EventType.AppStartInitFinish args)
        {
            UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid).Coroutine();

            ComputerTest(args.ZoneScene).Coroutine();
        }

        public async ETTask ComputerTest(Scene zoneScene)
        {
            Computer computer = zoneScene.AddChild<Computer>();
            Log.Debug("111111111111111111");
            //Game.EventSystem.Publish(new InstallComputer() { Computer = computer });
            Game.EventSystem.PublishAsync(new InstallComputerAsync() { Computer = computer }).Coroutine();
            Log.Debug("222222222222222222");
            var result = await TestAsync();
            computer.Start();
            Log.Debug(result.ToString());
            await TimerComponent.Instance.WaitAsync(3000);

            computer.Dispose();
        }

        public async ETTask<int> TestAsync()
        {
            const int Time = 1000;
            Log.Debug("xxxxxxxxxxxxxxxxxxxxxxxxxx");
            await TimerComponent.Instance.WaitAsync(Time);
            Log.Debug("yyyyyyyyyyyyyyyyyyyyyyyyyy");
            return Time;
        }
    }
}