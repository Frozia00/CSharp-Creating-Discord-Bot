# CSharp-Creating-Discord-Bot
This is a Discord Bot application which coded using C# with .NET Core .

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

- Install .NET Core SDK 3.0 from Microsoft. (to run NuGet console in VS Code, may be it's not necessary for your application. Try it.)

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
