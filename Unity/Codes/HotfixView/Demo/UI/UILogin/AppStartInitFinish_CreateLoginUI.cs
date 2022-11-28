using ET.EventType;
using System.Diagnostics;
using UnityEngine;

namespace ET
{
    public class AppStartInitFinish_CreateLoginUI : AEvent<EventType.AppStartInitFinish>
    {
        protected override async void Run(EventType.AppStartInitFinish args)
        {
            await UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid);

            ComputerTest(args.ZoneScene).Coroutine();

            //var result = await TestAsync();
            //Log.Debug(result.ToString());

            Log.Debug("111111111111111111");
            ETCancellationToken token = new();
            MoveAsync(Vector3.zero, token).Coroutine();
            token.Cancel();
            Log.Debug("222222222222222222");
        }

        public async ETTask ComputerTest(Scene zoneScene)
        {
            Computer computer = zoneScene.AddChild<Computer>();
            Game.EventSystem.Publish(new InstallComputer() { Computer = computer });
            //Game.EventSystem.PublishAsync(new InstallComputerAsync() { Computer = computer }).Coroutine();
            computer.Start();
            await TimerComponent.Instance.WaitAsync(1000);
            computer.Dispose();
        }

        public async ETTask MoveAsync(Vector3 pos, ETCancellationToken token)
        {
            Log.Debug("Move Start");
            bool ret = await TimerComponent.Instance.WaitAsync(3000, token);
            if (ret)
            {
                Log.Debug("Move Over");
            }
            else
            {
                Log.Debug("Move Stop");
            }
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