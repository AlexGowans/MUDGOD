using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;


using Discord;
using Discord.Commands;

namespace MUDGOD.Core.Commands {
    public class cmdHelloWorld : ModuleBase<SocketCommandContext> {
        [Command("hello"), AliasAttribute("helloworld", "world"), Summary("Hello World command")]
        public async Task Sjustin() {
            await Context.Channel.SendMessageAsync("Hello World");
        }
    }
}
