using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;



namespace MUDGOD.GameEngine.GameCommands {
    public class gameManager : ModuleBase<SocketCommandContext> {

        string answer; //for user responses


        [Command("register"), Summary("Register a new player")]
        public async Task Register() {
            //Check they aren't already registered
            if (Data.SaveLoad.CheckPlayerIsRegistered(Context.User.Id)) {
                await Context.Channel.SendMessageAsync($"You are already registered silly");
                return;
            }
            await Context.Channel.SendMessageAsync($"Welcome to {Program.mudgodName} MUDGOD.\n Register? Say **yes**");

        }
    }
}
