//This defines all 'creatures' in the world

//Example of creating an actor and only changeing set params
//Actor blep = new Actor(name: "poo", str: 100);

using System;
using System.Collections.Generic;
using System.Text;

namespace MUDGOD{
    class Actor {
        public string   name;
        public int bodySize; //0-5?
        public int healthPointsMax;
        public int healthPoints;
        public int manaPointsMax;
        public int manaPoints;
        public int strPoints;
        public int dexPoints;
        public int intPoints;
        public int lckPoints;
        public int defPoints;

        //Initialise
        public Actor(string name = "No-name",int size = 1,int hp = 100,int mp = 100, int str = 10, int dex = 10, int intP = 10, int lck = 10, int def = 10) {
            this.name = name;
            this.bodySize = size;
            this.healthPoints = this.healthPointsMax = hp;
            this.strPoints = str;
            this.dexPoints = dex;
            this.intPoints = intP;
            this.lckPoints = lck;
            this.defPoints = def;
        }
    }
}
