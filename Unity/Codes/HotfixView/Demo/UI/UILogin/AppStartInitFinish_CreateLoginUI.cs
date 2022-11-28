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

            var unitConfig = UnitConfigCategory.Instance.Get(1001);
            Log.Debug(unitConfig.Name);

            foreach (var config in UnitConfigCategory.Instance.GetAll().Values)
            {
                Log.Debug(config.Name);
                Log.Debug(config.TestVector3.ToString());
            }
            unitConfig = UnitConfigCategory.Instance.GetUnitConfigByHeight(178);
            Log.Debug(unitConfig?.Name);
        }
    }
}