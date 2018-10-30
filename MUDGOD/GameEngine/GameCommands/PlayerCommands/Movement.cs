using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using Discord;
using Discord.Addons.Interactive;
using Discord.Commands;
using Discord.WebSocket;

namespace MUDGOD.GameEngine.GameCommands.PlayerCommands {
    public class BasicSkills : InteractiveBase {

        [Command("whereami"),Alias("where","whereAmI","WhereAmI")]
        public async Task BaseWhereAmI() {
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


        [Command("go"), Alias("move", "saunter", "tiptoe")]
        public async Task BaseMove(string dir = "") {
            ulong id = Context.User.Id;
            var mention = Context.User.Mention;

            //Check they aren't already registered
            if (!Data.SaveLoad.CheckPlayerIsRegistered(id)) {
                await Context.Channel.SendMessageAsync($"{mention}\nYou need to register a Character first] **^register**");
                return;
            }

            PlayerCharacter pc = Data.SaveLoad.LoadPlayerCharacter(id);

            switch (dir) {
                case "n":
                    //Check tiles if can move

                    //Move
                    pc.locationY -= 1;
                    break;

                case "s":
                    //Check tiles if can move

                    //Move
                    pc.locationY += 1;
                    break;

                case "e":
                    //Check tiles if can move

                    //Move
                    pc.locationX += 1;
                    break;

                case "w":
                    //Check tiles if can move

                    //Move
                    pc.locationX -= 1;
                    await BaseWhereAmI();
                    break;


                default:
                await ReplyAsync($"{mention}\nYou must pick a direction] **n** **s** **e** **w**");
                return;
            
            }

            await Data.SaveLoad.SavePlayerCharacter(id, pc);
            
        }



    }
}
