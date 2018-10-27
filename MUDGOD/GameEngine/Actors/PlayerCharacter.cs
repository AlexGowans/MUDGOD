/*
 This script holds the player character class

 Ex/
 PlayerCharacter steve = new PlayerCharacter(new PeasantClass(), name: "Steve");
 
 
 */
using System;
using System.Collections.Generic;
using System.Text;

using Discord;
using Discord.Commands;
using System.ComponentModel.DataAnnotations;

namespace MUDGOD {
    public class PlayerCharacter : Actor {
        

        //Player Info
        [Key]
        public ulong playerId      { get; set; }
        public string playerName   { get; set; } //the name of the user, not character, that is in Actor and simply called name
        public PlayerClass myClass { get; set; }

        //Class levels : 0 = not unlocked yet   //Should this be in Actor? Gives NPCs options to have classes too then, or we could give them their own varient of the system?
        public int peasantLevel  { get; set; }
        public int fighterLevel  { get; set; }
        public int magicianLevel { get; set; }
        public int rangerLevel   { get; set; }

        //This constructor comes after the base actor and overwrites it
        public PlayerCharacter(ulong id, string plrNme, string nme, PlayerClass myCls,
                                int peasant = 1, int fighter = 0, int magician = 0, int ranger = 0,  //gives us the ability to grant classes right away if we want
                                int size = 1, int lev = 1,
                                int hp = 100, int mp = 100,
                                int str = 10, int dex = 10, int intP = 10, int wis = 10, int lck = 10, int def = 10,
                                int acc = 5, int dodge = 15,
                                int crncy = 0,
                                int locX = 0, int locY = 0) {
            playerId = id;
            playerName = plrNme;
            level = level;

            myClass = myCls;      //set the class
            peasantLevel = peasant;   //get default levels for your classes
            fighterLevel = fighter;
            magicianLevel = magician;
            rangerLevel = ranger;
            SetClassLevel();                //Set myClass.level to appropriate int, do this everytime you change class

            name = nme;
            bodySize = size;
            healthPoints = healthPointsMax = hp;
            manaPoints = manaPointsMax = mp;

            strPoints = str;
            dexPoints = dex;
            intPoints = intP;
            wisPoints = wis;
            lckPoints = lck;
            defPoints = def;

            accuracyPoints = acc;
            passiveDodgePoints = dodge;

            currency = crncy;

            locationX = locX;
            locationY = locY;
        }
        protected PlayerCharacter() { } //This is to allow the database to work, bug in current software 


        //Getting player stats after mods
        public int HpMax() {
            float me = healthPointsMax * myClass.hpMulti;
            return (int)me;
        }
        public int MpMax() {
            float me = manaPointsMax * myClass.mpMulti;
            return (int)me;
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

        //Taking hits //Overrides from Actor to use modified HpMax()
        public override void IncHp(int val) {
            healthPoints += val;    //increment
            if (healthPoints > HpMax()) healthPoints = HpMax(); //Check not above max
            if (healthPoints <= 0) {                            //Check for death
                healthPoints = 0;
                IDied();
            }
        } 
        public override void IncMp(int val) {
            manaPoints += val;    //increment
            if (manaPoints > MpMax()) manaPoints = MpMax(); //Check not above max
            if (manaPoints <= 0) manaPoints = 0;
        }
        public override void IDied() {
            //How to send message to default channel? Context throws an error even when public async override
            //await Context.Channel.SendMessageAsync("Hello World");
        }

        //Target Stuff
        public int RollToHit() {  //this will have to be compared against the targets passive dodge
            Random rnd = new Random();
            float me = accuracyPoints + rnd.Next(1, 21);    //acc + 1-20
            return (int)me;
        }
        public bool CheckIfHit(int acc) {
            if (acc > passiveDodgePoints) return true;  //return true if an attack hits you  
            return false;                               //otherwise return false
        }
        public bool CheckInRange(Actor target, int range) {
            if (Math.Abs(target.locationX - locationX) <= range) return true;
            return false;
        }


        //Class setting
        //Expand for comments
        public void SetClassLevel() {           //Run this after changing class --> might only need to be ran in init where we dont know which class we are getting
            if (myClass.name == "Peasant") {    //but during a manual change we do so could just set the level when we call the constructor
                myClass.level = peasantLevel;
            }
            if (myClass.name == "Fighter") {
                myClass.level = peasantLevel;
            }
            if (myClass.name == "Magician") {
                myClass.level = peasantLevel;
            }
            if (myClass.name == "Ranger") {
                myClass.level = peasantLevel;
            }
        }

    }
}
