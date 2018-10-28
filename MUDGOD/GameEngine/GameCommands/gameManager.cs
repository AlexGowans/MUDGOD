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


        TimeSpan responseTime = new TimeSpan(0,0,10);   //Time to alot the player to respond
        string answer; //for user responses


        [Command("register", RunMode = RunMode.Async), Summary("Register a new player")]
        public async Task Register() {
            ulong id = Context.User.Id;
            //Check they aren't already registered
            if (Data.SaveLoad.CheckPlayerIsRegistered(id)) {
                await Context.Channel.SendMessageAsync($"You are already registered silly");
                return;
            }
            await Context.Channel.SendMessageAsync($"Welcome to {Program.mudgodName} MUDGOD.\n Register? Say **yes**");

            var response = await NextMessageAsync(true,true, responseTime); //true/true : SameUsed/SameChannel
            answer = response.Content;
            if (answer == "yes") {
                await Context.Channel.SendMessageAsync($"Ok got this far");
            }

        }
    }
}
