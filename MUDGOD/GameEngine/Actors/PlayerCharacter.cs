/*
 This script holds the player character class

 Ex/
 PlayerCharacter steve = new PlayerCharacter(new PeasantClass(), name: "Steve");
 
 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace MUDGOD {
    class PlayerCharacter : Actor {
        //Player Info
        public int playerId;
        public string playerName; //the name of the user, not character, that is in Actor name


        public PlayerClass myClass;

        //This constructor comes after the base actor and overwrites it
        public PlayerCharacter(PlayerClass myClass,int id,string playerName = "No User", string name = "No-name",
                                int size = 1, int hp = 100, int mp = 100,
                                int str = 10, int dex = 10, int intP = 10,int wis = 10, int lck = 10, int def = 10,
                                int locX = 0, int locY = 0) {
            this.name = name;
            this.bodySize = size;
            this.healthPoints = this.healthPointsMax = hp;
            this.manaPoints = this.manaPointsMax = mp;
            this.strPoints = str;
            this.dexPoints = dex;
            this.intPoints = intP;
            this.wisPoints = wis;
            this.lckPoints = lck;
            this.defPoints = def;
            this.mapLocation.X = locX;
            this.mapLocation.Y = locY;

            this.playerId = id;
            this.playerName = name;
            this.myClass = myClass;
        }

        public float Strength() {
            float me = strPoints * myClass.strMulti;
            return me;
        }
        public float Dexterity() {
            float me = dexPoints * myClass.dexMulti;
            return me;
        }
        public float Intelligence() {
            float me = intPoints * myClass.intMulti;
            return me;
        }
        public float Wisdom() {
            float me = wisPoints * myClass.wisMulti;
            return me;
        }
        public float Luck() {
            float me = lckPoints * myClass.lckMulti;
            return me;
        }
    }
}
