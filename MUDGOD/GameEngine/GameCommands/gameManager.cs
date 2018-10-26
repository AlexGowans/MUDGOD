using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace MUDGOD {
    class gameManager : ModuleBase<SocketCommandContext> {
        //public PlayerCharacter[] playerList;   //this is our player list, load into it on startup, then add into it during registration

        [Command("register"), Summary("Register a new player")]
        public async Task Register() {
            
        }
    }
}
