# CSharp-Creating-Discord-Bot
This is a Discord Bot application which coded using C# with .NET Core .


## Contents 
### 1) Create Discord Developer App
### 2) C# Application

# 1) Create Discord Developer App
- Go to Discord Develpor Portal >>> https://discordapp.com/developers/applications/
- On "Applications" Tab, click the "New Application" button on top-right of page.
- Set the name of your bot in pop-up window. Then click the "Create" button.

![Screenshot_1](https://user-images.githubusercontent.com/58179070/70850490-e80aaf80-1e9b-11ea-8c26-ed4f6d63d2c4.jpg)

- You can set your bot's icon, description and permissions in the "General Information" Tab after the creating.

![Screenshot_2](https://user-images.githubusercontent.com/58179070/70850561-c78f2500-1e9c-11ea-98cf-09952f4c2e32.jpg)

- Click the "Bot" tab on your page's left column.

![Screenshot_3](https://user-images.githubusercontent.com/58179070/70850600-310f3380-1e9d-11ea-9e65-a2fe71e07a1c.jpg)

- Click "Yes do it" button when the message box is opened and add your bot.

- After that you'll see that page. And "click to reveal token". 

![Screenshot_4](https://user-images.githubusercontent.com/58179070/70850647-b98dd400-1e9d-11ea-9190-b8b9178436c2.jpg)

- The token is you will use it in C# application, so save it.

- Also the Client ID (in OAuth2 or General Information Tab) is you need to authorize for your Discord server to bot. Save it, too.

# 2) C# Application

- You should create a Console Application in Visual Studio.

Note: I haven't used Visual Stuido, my IDE is just "Visual Studio Code". So, may there be differences according Visual Studio.

- Install .NET Core SDK 3.0 from Microsoft.

- Install "NuGet Package Manaer", for VS Code open the Extensions and search the Nuget Package Manager

![Screenshot_5](https://user-images.githubusercontent.com/58179070/70850875-112d3f00-1ea0-11ea-8b58-6dbc49ade8e2.jpg)

- For add "DSharpPlus" package to NuGet, type CTRL+SHIFT+P and open the commands palette.
- Click the "NuGet Package Manager: Add Package" 

![Screenshot_6](https://user-images.githubusercontent.com/58179070/70851034-9f55f500-1ea1-11ea-9b72-47d2d0942a64.jpg)

- Type "DSharpPlus" to search.
- Then click it.
- Select to version of "3.2.3" from the opened list.

![Screenshot_7](https://user-images.githubusercontent.com/58179070/70851121-6b2f0400-1ea2-11ea-85c9-249beb8f8d35.jpg)
![Screenshot_8](https://user-images.githubusercontent.com/58179070/70851122-6b2f0400-1ea2-11ea-81cb-386f9a03f9cf.jpg)
![Screenshot_9](https://user-images.githubusercontent.com/58179070/70851123-6b2f0400-1ea2-11ea-93a4-773e32b1774b.jpg)

- Add this library for your program:

```csharp
using DSharpPlus;
```


- Create your OAuth2 link with Client ID. Like this: https://discordapp.com/oauth2/authorize?&client_id=655421891418390528&scope=bot&permissions=0

The "655421891418390528" is your Client ID, paste it after "client_id" tag in link.

- Enter the created link with client id and authorize your bot in your discord server. Like this:

![Screenshot_10](https://user-images.githubusercontent.com/58179070/70851891-2f993780-1eac-11ea-9cb4-55b4462963f5.jpg)


- Create your app codes, like this template (All details are commented):

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;

//OAuth2 URL's of bot is like this >>> https://discordapp.com/oauth2/authorize?&client_id=655421891418390528scope=bot&permissions=0
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
```


## Your bot application is ready for using to Discord. You only need start with debugging the program in console.
