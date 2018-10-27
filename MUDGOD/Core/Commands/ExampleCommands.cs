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
    public class ExampleCommands : ModuleBase<SocketCommandContext> {

        //HELLO] Basic bot speech on command, alias'
        [Command("hello"), AliasAttribute("helloworld", "world"), Summary("Hello World command")]
        public async Task Hello() {
            await Context.Channel.SendMessageAsync("Hello World");
        }
        //EMBED] Embed example
        [Command("embed"), Summary("Embedding example")]
        public async Task Embed([Remainder]string input = "None") {
            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithAuthor("MUD GOD", Context.User.GetAvatarUrl());
            Embed.WithColor(40, 200, 150);
            Embed.WithFooter("Embed Footer", Context.Guild.Owner.GetAvatarUrl());
            Embed.WithDescription("This is a shitty description\n" + "[This is a link](https://www.google.com/)");
            Embed.AddInlineField("User input:", input);


            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }

        //getting the sent message, getting the user who sent it
        [Command("repeat"), Summary("Repeats what you tell it")]
        public async Task example([Remainder]string message) {
            await Context.Channel.SendMessageAsync($"Message: {message} : by {Context.User.Username}");
        }


    }
}


/*Useful information
 *
 * 
 * public async Task example([Remainder]string message){
 *      await Context.Channel.SendMessageAsync($"Message: {message} : by {Context.User.Username)");
 * 
 * 
 * }
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */