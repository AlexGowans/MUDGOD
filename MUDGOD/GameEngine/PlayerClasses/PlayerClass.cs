using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace MUDGOD {
    class PlayerClass {
        [Key]
        public int id             { get; set; } //id# of class
        public string name        { get; set; }
        public string description { get; set; }
        public int level          { get; set; } //class level

        public float hpMulti  { get; set; }
        public float mpMulti  { get; set; }
        public float strMulti { get; set; }
        public float dexMulti { get; set; }
        public float intMulti { get; set; }
        public float wisMulti { get; set; }
        public float lckMulti { get; set; }
        public float defMulti { get; set; }

        public PlayerClass(string nme = "No Class", string desc = "No description", int lvl = 1,
                           float hp = 1, float mp = 1,
                           float str = 1, float dex = 1, float intP = 1, float wis = 1, float lck = 1, float def = 1) {
            name = nme;
            description = desc;
            level = lvl;

            hpMulti  = hp;
            mpMulti  = mp;
            strMulti = str;
            dexMulti = dex;
            intMulti = intP;
            wisMulti = wis;
            lckMulti = lck;
            defMulti = def;
        }
        protected PlayerClass() { }
    }


    class PeasantClass : PlayerClass {
        public PeasantClass() {
            this.id = 0;
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
            this.id = 1;
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
            this.id = 2;
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
            this.id = 3;
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
