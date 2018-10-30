using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using Discord;
using Discord.Addons.Interactive;
using Discord.Commands;
using Discord.WebSocket;

namespace MUDGOD.GameEngine.GameCommands.PlayerCommands {
    public class Movement : InteractiveBase {

        [Command("whereami"),Alias("where","whereAmI","WhereAmI")]
        public async Task MovementWhereAmI() {
            ulong id = Context.User.Id;
            var mention = Context.User.Mention;

            //Check they aren't already registered
            if (!Data.SaveLoad.CheckPlayerIsRegistered(id)) {
                await Context.Channel.SendMessageAsync($"{mention}\nYou need to register a Character first] **^register**");
                return;
            }

            PlayerCharacter pc = Data.SaveLoad.LoadPlayerCharacter(id);
            await ReplyAsync($"{mention}\nYou are located at [{pc.locationX},{pc.locationY}]");
            //give tile info?
        }
    }
}
