using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace MUDGOD {
    public class PlayerRace {
        [Key]
        public int id             { get; set; } //id# of race
        public string name        { get; set; }
        public string description { get; set; }

        public float hpMulti  { get; set; }
        public float mpMulti  { get; set; }
        public float strMulti { get; set; }
        public float dexMulti { get; set; }
        public float intMulti { get; set; }
        public float wisMulti { get; set; }
        public float lckMulti { get; set; }
        public float defMulti { get; set; }

        public PlayerRace(string nme = "No Race", string desc = "No description", int lvl = 1,
                           float hp = 1, float mp = 1,
                           float str = 1, float dex = 1, float intP = 1, float wis = 1, float lck = 1, float def = 1) {
            name = nme;
            description = desc;

            hpMulti  = hp;
            mpMulti  = mp;
            strMulti = str;
            dexMulti = dex;
            intMulti = intP;
            wisMulti = wis;
            lckMulti = lck;
            defMulti = def;
        }
        protected PlayerRace() { } //This is to allow the database to work, bug in current software
    }


    class HumanRace : PlayerRace {
        public HumanRace() {
            this.id = 0;
            this.name = "Human";
            this.description = "You are a Human";
            this.hpMulti = 1;
            this.mpMulti = 1;
            this.strMulti = 1;
            this.dexMulti = 1;
            this.intMulti = 1;
            this.wisMulti = 1;
            this.lckMulti = 1;
            this.defMulti = 1;
        }
    }

    class ElfRace : PlayerRace {
        public ElfRace() {
            this.id = 1;
            this.name = "Elf";
            this.description = "You are an Elf";
            this.hpMulti = 1;
            this.mpMulti = 1;
            this.strMulti = 1;
            this.dexMulti = 1;
            this.intMulti = 1;
            this.wisMulti = 1;
            this.lckMulti = 1;
            this.defMulti = 1;
        }
    }

    class DwarfRace : PlayerRace {
        public DwarfRace() {
            this.id = 2;
            this.name = "Dwarf";
            this.description = "You are a Dwarf";
            this.hpMulti = 1;
            this.mpMulti = 1;
            this.strMulti = 1;
            this.dexMulti = 1;
            this.intMulti = 1;
            this.wisMulti = 1;
            this.lckMulti = 1;
            this.defMulti = 1;
        }
    }

    class DragonbornRace : PlayerRace {
        public DragonbornRace() {
            this.id = 3;
            this.name = "Dragonborn";
            this.description = "You are half Man, half Dragon, half Born";
            this.hpMulti = 1;
            this.mpMulti = 1;
            this.strMulti = 1;
            this.dexMulti = 1;
            this.intMulti = 1;
            this.wisMulti = 1;
            this.lckMulti = 1;
            this.defMulti = 1;
        }
    }
}
