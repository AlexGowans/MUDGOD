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
                                int acc = 5, int dodge = 15,
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

            this.accuracyPoints = acc;
            this.passiveDodgePoints = dodge;

            this.mapLocation.X = locX;
            this.mapLocation.Y = locY;

            this.playerId = id;
            this.playerName = name;
            this.myClass = myClass;
        }

        //Getting player stats after mods
        public int HpMax() {
            float me = healthPointsMax * myClass.hpMulti;
            return (int)me;
        }
        public float MpMax() {
            float me = manaPointsMax * myClass.mpMulti;
            return me;
        }
        public int Strength() {
            float me = strPoints * myClass.strMulti;
            return (int)me;
        }
        public int Dexterity() {
            float me = dexPoints * myClass.dexMulti;
            return (int)me;
        }
        public int Intelligence() {
            float me = intPoints * myClass.intMulti;
            return (int)me;
        }
        public int Wisdom() {
            float me = wisPoints * myClass.wisMulti;
            return (int)me;
        }
        public int Luck() {
            float me = lckPoints * myClass.lckMulti;
            return (int)me;
        }
        public int Defense() {
            float me = (defPoints * myClass.defMulti); //+ armour from equips
            return (int)me;
        }

        //Taking hits
        public override void IncHp(int val) {
            healthPoints += val;
            if (healthPoints > HpMax()) healthPoints = HpMax();
        } 
        public override void IncMp(int val) {

        }
        public override void IDied() {

        }
        //Target Stuff
        public float RollToHit() {  //this will have to be compared against the targets passive dodge
            Random rnd = new Random();
            float me = accuracyPoints + rnd.Next(1, 21);    //acc + 1-20
            return me;
        }
    }
}
