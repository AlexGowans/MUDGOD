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
        //Initialise in main child
    }
}
