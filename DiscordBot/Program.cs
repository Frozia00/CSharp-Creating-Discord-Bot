using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;

//OAuth2 URL's of bot is like this >>> https://discordapp.com/oauth2/authorize?&client_id=655421891418390528&scope=bot&permissions=0
//This URL is only sample, you should create your own URL with your "client id".

namespace DiscordBot
{
    class Program
    {

        static DiscordClient discord;

        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
            
        }

        static async Task MainAsync(string[] args)
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "H1wBUFC6DV9JohuaZslSFavU7ZC2aBDI", // YOUR CLIENT'S TOKEN WHICH YOU SAVED IN BOT SETTINGS.
                TokenType = TokenType.Bot
            });

            discord.MessageCreated += async e =>
            {
                
                if (e.Message.Content.ToLower().StartsWith("Hi")) // The user's message
                    await e.Message.RespondAsync("Hi dude!"); // Bot's response

                if (e.Message.Content.ToLower() == "Hello Bot, how're you?") // The alternative code for sending message (w/o "StartsWith")
                    await e.Message.RespondAsync("https://imgur.com/gallery/0000.jpeg"); //Sample for responsing with Image link

                if (e.Message.Content.ToLower()=="!soldier") // You can create your own commands start with "!" or another thing.
                    await e.Message.RespondAsync("Yes sir!");

                if (e.Message.Content.ToLower()=="!random") // This is sample for random responsing from bot if you tpye "!random".
                {
                    Random rand = new Random();
                    int r = rand.Next(0,2); 
                    Console.WriteLine(r);   
                    if(r == 0)
                    {
                        await e.Message.RespondAsync("https://imgur.com/gallery/111111.jpeg");
                    }
                    else 
                    {
                        await e.Message.RespondAsync("https://imgur.com/gallery/222222.jpeg");
                    }
                    
                }
            };
            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}