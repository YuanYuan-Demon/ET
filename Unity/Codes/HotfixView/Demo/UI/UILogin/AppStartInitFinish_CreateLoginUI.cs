namespace ET
{
    public class AppStartInitFinish_CreateLoginUI : AEvent<EventType.AppStartInitFinish>
    {
        protected override void Run(EventType.AppStartInitFinish args)
        {
            UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid).Coroutine();

            Test(args.ZoneScene).Coroutine();
        }

        public async ETTask Test(Scene zoneScene)
        {
            Computer computer = zoneScene.AddChild<Computer>();
            computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorComponent>();
            computer.AddComponent<MouseComponent>();
            computer.AddComponent<KeyboardComponent>();

            computer.Start();

            await TimerComponent.Instance.WaitAsync(3000);

            computer.Dispose();
        }
    }
}