using System;
using System.Collections.Generic;
using System.Text;

namespace MUDGOD {
    class PlayerClass {
        public string name;
        public float hpMulti;
        public float mpMulti;
        public float strMulti;
        public float dexMulti;
        public float intMulti;
        public float lckMulti;
        public float defMulti;
        //Set in Defined Class Scripts
        
    }


    class PeasantClass : PlayerClass {

        public PeasantClass(string name = "No Class", float hp = 1, float mp = 1, float str = 1, float dex = 1, float intP = 1, float lck = 1, float def = 1) {
            this.name = name;
            this.hpMulti = hp;
            this.mpMulti = mp;
            this.strMulti = str;
            this.dexMulti = dex;
            this.intMulti = intP;
            this.lckMulti = lck;
            this.defMulti = def;
        }
    }
}
