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
        public int healthPointsMax;
        public int healthPoints;
        public int manaPointsMax;
        public int manaPoints;
        public int strPoints;
        public int dexPoints;
        public int intPoints;
        public int lckPoints;
        public int defPoints;

        public Vector2 mapLocation = new Vector2(0,0);

        //INITIALISE
        public Actor(string name = "No-name",
                                int size = 1, int hp = 100, int mp = 100, int str = 10, int dex = 10, int intP = 10, int lck = 10, int def = 10,
                                int locX = 0, int locY = 0) {
            this.name = name;
            this.bodySize = size;
            this.healthPoints = this.healthPointsMax = hp;
            this.manaPoints = this.manaPointsMax = mp;
            this.strPoints = str;
            this.dexPoints = dex;
            this.intPoints = intP;
            this.lckPoints = lck;
            this.defPoints = def;
            this.mapLocation.X = locX;
            this.mapLocation.Y = locY;
        }
    }
}
