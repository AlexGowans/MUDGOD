/*
 This Script is an an example of how to use command features
 
 
 
 */

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

using Discord;
using Discord.Commands;



namespace MUDGOD.Core.Commands {
    public class cmdHelloWorld : ModuleBase<SocketCommandContext> {

        //HELLO
        [Command("hello"), AliasAttribute("helloworld", "world"), Summary("Hello World command")]
        public async Task Hello() {
            await Context.Channel.SendMessageAsync("Hello World");
        }

        //EMBED
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
    }
}
