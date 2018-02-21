using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.VoiceNext;

namespace RoboFzzy
{
    class Commands
    {
        List<Cooldown> cooldowns = new List<Cooldown>();
        const int cooldown = 30;

        [Command("all")]
        public async Task All(CommandContext ctx, DiscordChannel chn = null)
        {
            await ctx.Member.SendMessageAsync(
                ".autism\n" +
                ".coconut\n" +
                ".doink\n" +
                ".drummer\n" +
                ".goblin\n" +
                ".mad\n" +
                ".massivelegend\n" +
                ".orange\n" +
                ".stutter\n" +
                ".yikes\n" +
                ".poom\n" +
                ".thot\n" +
                ".bully\n" +
                ".fungame\n" +
                ".gay\n" +
                ".work\n" +
                ".guacamole\n" +
                ".dontrun\n" +
                ".child\n" +
                ".bone\n" +
                ".nips");
        }

        [Command("nips")]
        public async Task Nips(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\nips.wav", chn);
        }

        [Command("bone")]
        public async Task Bone(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\bone.wav", chn);
        }

        [Command("child")]
        public async Task Child(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\child.mp3", chn);
        }

        [Command("dontrun")]
        public async Task DontRun(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\dontrun.wav", chn);
        }

        [Command("guacamole")]
        public async Task Guacamole(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\guacamole.wav", chn);
        }

        [Command("work")]
        public async Task Work(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\work.wav", chn);
        }

        [Command("gay")]
        public async Task Gay(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\gay.wav", chn);
        }

        [Command("fungame")]
        public async Task FunGame(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\fungame.mp3", chn);
        }

        [Command("bully")]
        public async Task Bully(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\bully.mp3", chn);
        }

        [Command("thot")]
        public async Task Thot(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\thot.mp3", chn);
        }

        [Command("poom")]
        public async Task Poom(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\poom.mp3", chn);
        }

        [Command("mad")]
        public async Task Mad(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\mad.mp3", chn);
        }

        [Command("massivelegend")]
        public async Task MassiveLegend(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\massive_legend.wav", chn);
        }

        [Command("autism")]
        public async Task Autism(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\autism.wav", chn);
        }

        [Command("coconut")]
        public async Task Coconut(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\coconut.wav", chn);
        }

        [Command("doink")]
        public async Task Doink(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\doink.wav", chn);
        }

        [Command("drummer")]
        public async Task Drummer(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\drummer.mp3", chn);
        }

        [Command("goblin")]
        public async Task Goblin(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\goblin.wav", chn);
        }

        [Command("orange")]
        public async Task Orange(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\orange.wav", chn);
        }

        [Command("stutter")]
        public async Task Stutter(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\stutter.wav", chn);
        }

        [Command("yikes")]
        public async Task Yikes(CommandContext ctx, DiscordChannel chn = null)
        {
            // handle cooldowns
            Boolean cd = CheckCooldown(ctx.Member.Id);
            if (cd)
            {
                await ctx.RespondAsync("You are on cooldown.");
                return;
            }

            PlayAudio(ctx, @"audio\yikes.wav", chn);
        }

        [Command("custom")]
        public async Task Custom(CommandContext ctx, [RemainingText, Description("Full path to the file to play.")] string filename, DiscordChannel chn = null)
        {
            if (ctx.Member.Id == 66104132028604416)
            {
                PlayAudio(ctx, @"audio\custom\" + filename, chn);
            }
        }

        public Boolean CheckCooldown(ulong id)
        {
            if (id == 66104132028604416)
            {
                return false;
            }
            foreach (Cooldown c in cooldowns)
            {
                if (c.id == id)
                {
                    if (Environment.TickCount - c.lastUsed < cooldown * 1000)
                    {
                        return true;
                    }
                    cooldowns.Remove(c);
                    break;
                }
            }
            cooldowns.Add(new Cooldown(id, Environment.TickCount));
            return false;
        }

        public async void PlayAudio(CommandContext ctx, string s, DiscordChannel chn = null)
        {
            // JOIN VOICE CHANNEL
            // check whether VNext is enabled
            var vnext = ctx.Client.GetVoiceNextClient();
            if (vnext == null)
            {
                // not enabled
                await ctx.RespondAsync("VNext is not enabled or configured.");
                return;
            }

            // check whether we aren't already connected
            var vnc = vnext.GetConnection(ctx.Guild);
            if (vnc != null)
            {
                // already connected
                await ctx.RespondAsync("Already playing.");
                return;
            }

            // get member's voice state
            var vstat = ctx.Member?.VoiceState;
            if (vstat?.Channel == null && chn == null)
            {
                // they did not specify a channel and are not in one
                await ctx.RespondAsync("You are not in a voice channel.");
                return;
            }

            // channel not specified, use user's
            if (chn == null)
                chn = vstat.Channel;

            // connect
            vnc = await vnext.ConnectAsync(chn);

            //PLAY AUDIO

            // check if file exists
            if (!File.Exists(s))
            {
                // file does not exist
                await ctx.RespondAsync("File does not exist.");
                return;
            }

            // wait for current playback to finish
            while (vnc.IsPlaying)
                await vnc.WaitForPlaybackFinishAsync();

            // play
            Exception exc = null;
            await vnc.SendSpeakingAsync(true);
            try
            {
                // borrowed from
                // https://github.com/RogueException/Discord.Net/blob/5ade1e387bb8ea808a9d858328e2d3db23fe0663/docs/guides/voice/samples/audio_create_ffmpeg.cs

                var ffmpeg_inf = new ProcessStartInfo
                {
                    FileName = "ffmpeg",
                    Arguments = $"-i \"{s}\" -ac 2 -f s16le -ar 48000 pipe:1",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };
                var ffmpeg = Process.Start(ffmpeg_inf);
                var ffout = ffmpeg.StandardOutput.BaseStream;

                // let's buffer ffmpeg output
                using (var ms = new MemoryStream())
                {
                    await ffout.CopyToAsync(ms);
                    ms.Position = 0;

                    var buff = new byte[3840]; // buffer to hold the PCM data
                    var br = 0;
                    while ((br = ms.Read(buff, 0, buff.Length)) > 0)
                    {
                        if (br < buff.Length) // it's possible we got less than expected, let's null the remaining part of the buffer
                            for (var i = br; i < buff.Length; i++)
                                buff[i] = 0;

                        await vnc.SendAsync(buff, 20); // we're sending 20ms of data
                    }
                }
            }
            catch (Exception ex) { exc = ex; }
            finally
            {
                await vnc.SendSpeakingAsync(false);
            }

            if (exc != null)
                await ctx.RespondAsync($"An exception occured during playback: `{exc.GetType()}: {exc.Message}`");

            // LEAVE VOICE CHANNEL
            vnc.Disconnect();
        }
    }
}
