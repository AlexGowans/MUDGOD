using System;
using System.Collections.Generic;
using System.Text;

namespace MUDGOD {
    class PlayerClass {
        public string name;
        public string description;
        public int level; //class level

        public float hpMulti;
        public float mpMulti;
        public float strMulti;
        public float dexMulti;
        public float intMulti;
        public float wisMulti;
        public float lckMulti;
        public float defMulti;

        public PlayerClass(string name = "No Class", string desc = "No description", int level = 1,
                           float hp = 1, float mp = 1,
                           float str = 1, float dex = 1, float intP = 1, float wis = 1, float lck = 1, float def = 1) {
            this.name = name;
            this.description = desc;
            this.level = level;

            this.hpMulti  = hp;
            this.mpMulti  = mp;
            this.strMulti = str;
            this.dexMulti = dex;
            this.intMulti = intP;
            this.wisMulti = wis;
            this.lckMulti = lck;
            this.defMulti = def;
        }

    }


    class PeasantClass : PlayerClass {
        public PeasantClass() {
            this.name = "Peasant";
            this.description = "You are a peasant";
            this.hpMulti = 0.3f;
            this.mpMulti = 0.3f;
            this.strMulti = 0.3f;
            this.dexMulti = 0.3f;
            this.intMulti = 0.3f;
            this.wisMulti = 0.3f;
            this.lckMulti = 0.3f;
            this.defMulti = 0.3f;
        }
    }

    class FighterClass : PlayerClass {
        public FighterClass() {
            this.name = "Fighter";
            this.description = "You smash good";
            this.hpMulti = 1.2f;
            this.mpMulti = 0.6f;
            this.strMulti = 1.5f;
            this.dexMulti = 1.2f;
            this.intMulti = 0.6f;
            this.wisMulti = 0.6f;
            this.lckMulti = 1;
            this.defMulti = 1.4f;
        }
    }

    class MagicianClass : PlayerClass {
        public MagicianClass() {
            this.name = "Magician";
            this.description = "You are attuned to the arcane n ting";
            this.hpMulti = 0.6f;
            this.mpMulti = 1.2f;
            this.strMulti = 0.6f;
            this.dexMulti = 0.6f;
            this.intMulti = 1.4f;
            this.wisMulti = 1.4f;
            this.lckMulti = 1;
            this.defMulti = 0.6f;
        }
    }

    class RangerClass : PlayerClass {
        public RangerClass() {
            this.name = "Ranger";
            this.description = "You are one with the bow, and the wild I guess";
            this.hpMulti = 1.1f;
            this.mpMulti = 0.8f;
            this.strMulti = 1.2f;
            this.dexMulti = 1.5f;
            this.intMulti = 0.6f;
            this.wisMulti = 0.6f;
            this.lckMulti = 1;
            this.defMulti = 1.1f;
        }
    }
}
