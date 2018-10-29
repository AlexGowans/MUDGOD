using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using Discord;
using Discord.Addons.Interactive;
using Discord.Commands;
using Discord.WebSocket;




namespace MUDGOD.GameEngine.GameCommands {
    public class GameManager : InteractiveBase {

        TimeSpan responseTime = new TimeSpan(0, 0, 15);   //Time to alot the player to respond
        string answer; //for user responses


        [Command("register", RunMode = RunMode.Async), Summary("Register a new player")]
        public async Task Register() {

            ulong id = Context.User.Id;
            var mention = Context.User.Mention;            

            //Check they aren't already registered
            if (Data.SaveLoad.CheckPlayerIsRegistered(id)) {
                await Context.Channel.SendMessageAsync($"{mention}\nYou are already registered silly");
                return;
            }

            //For creating a new PC
            string newName = "";
            int newRace; //this is an id, it gets attached on creation


            //Confirm user wants to register
            await Context.Channel.SendMessageAsync($"{mention}\nWelcome to {Program.mudgodName} MUDGOD.\n Register? Say **yes**");
            var response = await NextMessageAsync(true, true, responseTime); //true/true : SameUsed/SameChannel
            if (response == null) { //not quick enough
                await ReplyAsync($"{mention}\nYou did not respond in time");
                return;
            }
            answer = response.Content;
            if (answer != "yes" && answer != "Yes" && answer != "Y" && answer !="y") return;
            
            //Get Charactername
            await ReplyAsync($"{mention}\nExcellent, what should I call you?");
            response = await NextMessageAsync(true, true, responseTime); //true/true : SameUsed/SameChannel
            if (response == null) { //not quick enough
                await ReplyAsync($"{mention}\nYou did not respond in time\nTo try again use **^register**");
                return;
            }
            newName = response.Content;
            if (newName == "") {
                await ReplyAsync($"{mention}\nYou must enter a name\nPlease try again **^register**");
                return;
            }
            await ReplyAsync($"{mention}\n{newName} huh? Guess it takes all sorts");

            //Get Character Race
            await ReplyAsync($"{mention}\nWhat Race are you?\nHuman\nElf\nDwarf\nDragonborn");
            response = await NextMessageAsync(true, true, responseTime); //true/true : SameUsed/SameChannel
            if (response == null) { //not quick enough
                await ReplyAsync($"{mention}\nYou did not respond in time\nTo try again use **^register**");
                return;
            }
            answer = response.Content;
            if (answer == "Human" || answer == "human") newRace = 0; //Capitalise answers
            else if (answer == "Elf" || answer == "elf") newRace = 1;
            else if (answer == "Dwarf" || answer == "dwarf") newRace = 2;
            else if (answer == "Dragonborn" || answer == "Dragonborn") newRace = 3;
            else {
                await ReplyAsync($"{mention}\nYou must enter a valid race\nPlease try again **^register**");
                return;
            }

            //Confirm
            await ReplyAsync($"{mention}\nYou are **{newName}** the **{PlayerRaceFunctions.GetRace(newRace).name}**\n Is this correct? Say **yes**");
            response = await NextMessageAsync(true, true, responseTime); //true/true : SameUsed/SameChannel
            if (response == null) { //not quick enough
                await ReplyAsync($"{mention}\nYou did not respond in time\nTo try again use **^register**");
                return;
            }
            answer = response.Content;
            if (answer != "yes" && answer != "Yes" && answer != "Y" && answer != "y") return;

            //Create New PC
            PlayerCharacter newPC = new PlayerCharacter(id,Context.User.Username,newName, 0, newRace);

            await ReplyAsync("Made the pc froze saving ");

            //Save to Database
            await Data.SaveLoad.SavePlayerCharacter(id, newPC);
            await ReplyAsync($"{mention}\nWelcome to the world {newPC.name}");

        }
    }
}
