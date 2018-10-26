//This defines all 'creatures' in the world

//Example of creating an actor and only changeing set params
//Actor blep = new Actor(name: "poo", str: 100);

using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;  //sweet Vector2

namespace MUDGOD{
    class Actor {
        public string name;
        public int bodySize; //0-5?
        public int level;

        public int healthPointsMax;
        public int healthPoints;
        public int manaPointsMax;
        public int manaPoints;

        public int strPoints;
        public int dexPoints;
        public int intPoints;//blk mgc
        public int wisPoints;//wht mgc
        public int lckPoints;
        public int defPoints;

        public int accuracyPoints;      //kind of like attack in dnd, add d20 roll and compare to target passive dodge
        public int passiveDodgePoints;

        public int currency;

        public Vector2 mapLocation = new Vector2(0,0);

        //INITIALISE
        public Actor(string name = "No-name", int size = 1, int level = 1,
                                int hp = 100, int mp = 100,
                                int str = 10, int dex = 10, int intP = 10, int wis = 10, int lck = 10, int def = 10,
                                int acc = 5, int dodge = 15,
                                int currency = 0,
                                int locX = 0, int locY = 0) {
            this.name = name;
            this.bodySize = size;
            this.level = level;

            this.healthPoints = this.healthPointsMax = hp;
            this.manaPoints = this.manaPointsMax = mp;

            this.strPoints = str;
            this.dexPoints = dex;
            this.intPoints = intP;
            this.lckPoints = lck;
            this.wisPoints = wis;
            this.defPoints = def;

            this.accuracyPoints = acc;
            this.passiveDodgePoints = dodge;

            this.currency = currency;

            this.mapLocation.X = locX;
            this.mapLocation.Y = locY;
        }

        //Taking hits
        public virtual void IncHp(int val) {

        }
        public virtual void IncMp(int val) {

        }
        public virtual void IDied() {

        }
    }
}
