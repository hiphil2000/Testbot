using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace Testbot.Modules
{
    public class InfoModule : ModuleBase<SocketCommandContext>
    {
        private readonly DiscordSocketClient _client;

        public InfoModule(
            DiscordSocketClient client)
        {
            _client = client;
        }

        [Command("topic"), Summary("Echoes topics on this channel")]
        public async Task Topic([Summary("channel id")] ulong channelId)
        {
            await Console.Out.WriteLineAsync(Context.Channel.Id.ToString());
            await Context.Channel.SendMessageAsync
                (GetChannelTopic(Context.Channel.Id));
        }

        private string GetChannelTopic(ulong channelId)
        {
            var channel = _client.GetChannel(channelId) as SocketTextChannel;
            if (channel == null) return "";
            return channel.Topic;
        }
    }

}
