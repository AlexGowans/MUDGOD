/*
 This Script is an an example of how to use command features
 
 
 
 */

using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;



namespace MUDGOD.Core.Commands {
    public class ExampleGroupCommands : ModuleBase<SocketCommandContext> {
        //GROUPS] Example of group commands
        [Group("currency"),Alias("money"), Summary("Example store")]
        public class ExampleGroupCommandsGroup : ModuleBase<SocketCommandContext> {
            //^currency || ^money || ^gold
            [Command(""),Alias("gold"),Summary("Example store")]
            public async Task Currency() {
                await Context.Channel.SendMessageAsync("This is a test command");
            }
            //^store buy || ^money buy || ^gold buy
            [Command("give"), Alias("gift"), Summary("Buy things")]
            public async Task GiveCurrency(IUser user = null, int amount = 0) {//Get a user that's been tagged and an in, AFTER ^currency give
                //Checks
                //User has permission?
                //User actually mentioned someone?
                if (user == null) { //user.IsBot checks for bots if anyone cares
                    //No user mentioned
                    await Context.Channel.SendMessageAsync("You have to say you want to give it to] **@user** amount");
                    return;
                }
                //User has enough money
                if (amount == 0) {
                    await Context.Channel.SendMessageAsync("You can't give someone nothing] @user **amount**");
                    return;
                }
                /*This block prevents non admins
                SocketGuildUser user1 = Context.User as SocketGuildUser;
                if(!User1.GuildPermissions.Administrator){
                    return;
                }
                */

                //Now we know we can go ahead with the trade now
                //Do the thing
                //Calculatae(gambling ect)
                //Announce
                await Context.Channel.SendMessageAsync($":tada: {user.Mention} you have received **{amount}** gold from {Context.User.Username}!");
                

                //Save to database


            }

        }
    }
}
