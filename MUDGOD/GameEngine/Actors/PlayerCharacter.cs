using System;
using System.Collections.Generic;
using System.Text;

namespace MUDGOD {
    class PlayerCharacter : Actor {
        public string playerName; //the name of the user, not character, that is in Actor name
        public PlayerClass myClass;


        public PlayerCharacter(PlayerClass myClass,string playerName = "No User", string name = "No-name",
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

            this.playerName = name;
            this.myClass = myClass;
        }
    }
}
