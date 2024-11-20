﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windowsForms_client.BuilderPattern;
using windowsForms_client.Tanks;

namespace windowsForms_client.AbstractFactoryPatternn.Factorys
{
    public class RedFactory : AbstractFactory
    {
        public override Tank createPistolTank(string id, int x, int y)
        {
            Tank redPistolTank = new RedPistolTank(id, x, y, "redPistolTank");
            Builder builder = new PistolTankBuilder();

            return builder.StartNew(redPistolTank).AssembleBody().AddWeapons().AddTurret().AddDecoration().GetBuildable();   
        }


        public override Tank createTommyGunTank(string id, int x, int y)
        {
            Tank redTommyGunTank = new RedTommyGunTank(id, x, y, "redTommyGunTank");
            Builder builder = new TommyGunTankBuilder();

            return builder.StartNew(redTommyGunTank).AssembleBody().AddWeapons().AddTurret().AddDecoration().GetBuildable();
        }

        public override Tank createShotgunTank(string id, int x, int y)
        {
            Tank redShotgunTank = new RedShotgunTank(id, x, y, "redShotgunTank");
            Builder builder = new ShotgunTankBuilder();

            return builder.StartNew(redShotgunTank).AssembleBody().AddWeapons().AddTurret().AddDecoration().GetBuildable();
        }
    }
}
