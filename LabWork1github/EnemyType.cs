﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork1github
{
    public abstract class EnemyType
    {
        public int Health { get; set; }
        public int Heal { get; set; }
        public int Damage { get; set; }
        public Place TeleportPlace { get; set; }
        public Place SpawnPlace { get; set; }
        public EnemyType SpawnType { get; set; }

        public abstract void Step();
    }
}
