using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.VoiceNext;

namespace RoboFzzy
{
    class Program
    {
        static DiscordClient discord;
        static VoiceNextClient voice;
        static CommandsNextModule commands;

        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "NDEwNTk2MTYzNzM4MTQwNjg0.DVvdBA.Bd0Fe0shsW3GRujTY7WvpZcjeiA",
                TokenType = TokenType.Bot,
                UseInternalLogHandler = true,
                LogLevel = LogLevel.Debug
            });

            commands = discord.UseCommandsNext(new CommandsNextConfiguration
            {
                StringPrefix = ".",
                EnableDms = false
            });
            commands.RegisterCommands<Commands>();

            voice = discord.UseVoiceNext();

            await discord.ConnectAsync();

            await Task.Delay(1000);
            await discord.UpdateStatusAsync(new DSharpPlus.Entities.DiscordGame(".all"));

            await Task.Delay(-1);
        }
    }
}
