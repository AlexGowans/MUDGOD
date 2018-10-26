using System;
using System.Reflection; //For sending bot commands
using System.Threading.Tasks;

using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace MUDGOD {
    class Program {
        private DiscordSocketClient Client;
        private CommandService Commands;
        private TOKEN tokenFile;

        static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        private async Task MainAsync() {
            Client = new DiscordSocketClient(new DiscordSocketConfig {
                LogLevel = LogSeverity.Debug
            });

            Commands = new CommandService(new CommandServiceConfig {
                CaseSensitiveCommands = true,
                DefaultRunMode = RunMode.Async,
                LogLevel = LogSeverity.Debug
            });

            Client.MessageReceived += Client_MessageReceived;
            await Commands.AddModulesAsync(Assembly.GetEntryAssembly()); //needed for commands to work

            Client.Ready += Client_Ready;   //Runs on Client Log in
            Client.Log   += Client_Log;     //Runs on receiving a log update

            await Client.LoginAsync(TokenType.Bot, tokenFile.token); //get bot token and log in
        }

        private Task Client_Log(LogMessage arg) {
            throw new NotImplementedException();
        }

        private Task Client_Ready() {
            throw new NotImplementedException();
        }

        private Task Client_MessageReceived(SocketMessage arg) {
            throw new NotImplementedException();
        }




    }
}
