/*
 MAIN PROGRAM
 INITIALISES THE BOT AND LISTENS FOR COMMANDS 
 */


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
        private TOKEN tokenFile = new TOKEN();

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

            await Client.LoginAsync(TokenType.Bot, tokenFile.token);    //get bot token and log in
            await Client.StartAsync();                                 //Start Client

            await Task.Delay(-1);           //Wait for a task forever
        }

        private async Task Client_Log(LogMessage message) {
            Console.WriteLine($"{DateTime.Now} at {message.Source}> {message.Message}");
        }

        private async Task Client_Ready() {
            await Client.SetGameAsync("your mother", "https://github.com/AlexGowans/MUDGOD", StreamType.NotStreaming); //Set Bot User now playing status
        }

        private async Task Client_MessageReceived(SocketMessage arg) {
            //Configure the commands
            throw new NotImplementedException();
        }




    }
}
