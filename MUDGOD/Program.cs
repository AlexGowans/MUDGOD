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
        private TOKEN tokenFile = new TOKEN();  //Core/TOKEN/TOKEN.cs  add this file w a public string 'token'
        private static readonly string commandPrefix = "^";


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

        private async Task Client_MessageReceived(SocketMessage messageParam) {
            //Configure the commands
            var message = messageParam as SocketUserMessage;
            var context = new SocketCommandContext(Client, message);

            if (context.Message == null || context.Message.Content == "") return;   //empty message? cant be a command
            if (context.User.IsBot) return;                                         //Ignore bots

            //If it's not a mention or doesn't have the command prefix, its not a command
            int argPos = 0;
            if (!(message.HasStringPrefix(commandPrefix, ref argPos) || message.HasMentionPrefix(Client.CurrentUser, ref argPos))) return;

            var result = await Commands.ExecuteAsync(context, argPos);
            if (!result.IsSuccess) {
                //Debug
                Console.WriteLine($"{DateTime.Now}: Error executing a command\nUser: {context.Message.Content}\nError{result.ErrorReason}");
            }
        }




    }
}
