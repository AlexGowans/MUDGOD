//This defines all 'creatures' in the world

//Example of creating an actor and only changeing set params
//Actor blep = new Actor(name: "poo", str: 100);

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MUDGOD{
    public class Actor {
        public string name  { get; set; }
        public int bodySize { get; set; } //0-5?
        public int level    { get; set; }

        public int healthPointsMax  { get; set; }
        public int healthPoints     { get; set; }
        public int manaPointsMax    { get; set; }
        public int manaPoints       { get; set; }

        public int strPoints { get; set; }
        public int dexPoints { get; set; }
        public int intPoints { get; set; }//blk mgc
        public int wisPoints { get; set; }//wht mgc
        public int lckPoints { get; set; }
        public int defPoints { get; set; }

        public int accuracyPoints { get; set; }      //kind of like attack in dnd, add d20 roll and compare to target passive dodge
        public int passiveDodgePoints { get; set; }

        public int currency { get; set; }

        public int locationX { get; set; }
        public int locationY { get; set; }

        //INITIALISE
        /*
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

            this.locationX = locX;
            this.locationY = locY;
        }
        */

        //Taking hits
        public virtual void IncHp(int val) {

        }
        public virtual void IncMp(int val) {

        }
        public virtual void IDied() {

        }
    }
}
