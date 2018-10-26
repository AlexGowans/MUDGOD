using System;
using System.Collections.Generic;
using System.Text;

namespace MUDGOD {
    class PlayerClass {
        public string name;
        public string description;
        public float hpMulti;
        public float mpMulti;
        public float strMulti;
        public float dexMulti;
        public float intMulti;
        public float lckMulti;
        public float defMulti;

        public PlayerClass(string name = "No Class", string desc = "No description", float hp = 1, float mp = 1, float str = 1, float dex = 1, float intP = 1, float lck = 1, float def = 1) {
            this.name = name;
            this.hpMulti  = hp;
            this.mpMulti  = mp;
            this.strMulti = str;
            this.dexMulti = dex;
            this.intMulti = intP;
            this.lckMulti = lck;
            this.defMulti = def;
        }

    }


    class PeasantClass : PlayerClass {
        public PeasantClass() {
            this.name = "Peasant";
            this.description = "You are a peasant";
            this.hpMulti  = 0.3f;
            this.mpMulti  = 0.3f;
            this.strMulti = 0.3f;
            this.dexMulti = 0.3f;
            this.intMulti = 0.3f;
            this.lckMulti = 0.3f;
            this.defMulti = 0.3f;
        }
    }
}
