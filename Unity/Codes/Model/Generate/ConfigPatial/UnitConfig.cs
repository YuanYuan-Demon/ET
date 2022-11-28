using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public partial class UnitConfig
    {
        public Vector3 TestVector3;
    }

    public partial class UnitConfigCategory
    {
        public List<Vector3> Vector3s = new();

        public override void AfterEndInit()
        {
            base.AfterEndInit();
            foreach (var config in this.dict.Values)
            {
                config.TestVector3 = new Vector3(config.Position, config.Height, config.Weight);
                Vector3s.Add(config.TestVector3);
            }
        }

        public UnitConfig GetUnitConfigByHeight(int height)
        {
            return this.dict.Values.SingleOrDefault(uc => uc.Height == height);
        }
    }
}