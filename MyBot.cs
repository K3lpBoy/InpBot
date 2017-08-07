using Discord;
using Discord.Commands;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InpBot
{
	class MyBot
	{
		DiscordClient discord;

		string[] redSayingNo;
        string[] helloMessages;
        string[] petMessages;
        string[] petMessageImages;
        string[] statusMessages;
        string[] manleyInsults;

		Random rand;

		public MyBot()
		{
			redSayingNo = new String[] //Red
			{
				"redSayingNo/no_1.png",
				"redSayingNo/no_2.png",
				"redSayingNo/no_3.png",
				"redSayingNo/no_4.png",
				"redSayingNo/no_5.png",
				"redSayingNo/no_6.png",
				"redSayingNo/no_7.png",
				"redSayingNo/no_8.png",
				"redSayingNo/no_9.png"
			};

            helloMessages = new String[]
            {
                "Skree-ki!",
                "Hrooom!", //Red
                "Skree-he-he!",
                "H-hewwo?", //Red
                "Skree-ha!",
                "Skree-kiki-ki!", //Medik3esta Tithis
                "*he looks at you hungrily*", //Farlight
            };

            petMessageImages = new String[]
            {
                "petMessage/inpHeartU.jpg",
                "petMessage/thank4pet.jpg"
            };

            manleyInsults = new String[]
            {
                "Manley, you aristocratic moss",
                "Manley, you aristocratic moss",
                "Manley, you aristocratic moss",
                "Manley, you pompous twig",
                "Manley, you pompous twig",
                "Manley, you pompous twig",
                "Manley, you son of a birch",
                "Manley, you son of a birch",
                "Manley, you son of a birch",
                "Manley, you son of a birhc"
            };

            statusMessages = new String[]
            {
                "*Blaspheming*",
                "*Blaspheming more than usual*",
                "*Having a quick nap*",
                "*Being petted*",
                "*Spamming Bound Together in Manley's Fanleys*",
                "*Being Red's personal no button*",
                "*Pinne*",
                "*Banne*",
                "*Cursing up a storm*",
                "*Sitting quietly*",
                "*Coiled up by the campfire*",
                "*Having his shitposts liked by Darren Korb*",
                "*Praising his creator*",
                "*Staring at the book*",
                "*Crying over Smug's fanfictions*",
                "*Backreading the entirety of #pyre-major-spoilers*",
                "*Backreading the entirety of #pyre-minor-spoilers*",
                "*Fangirling over Jodariel*"
            };

            petMessages = new string[]
            {
                "*blarg*",
                "*Skaboo~*",
                "*fart noise*",
                "`You pet the imp and it falls over.`",
               "*blarg*",
                "*Skaboo~*",
                "*fart noise*",
                "`You pet the imp and it falls over.`",
                "*blarg*",
                "*Skaboo~*",
                "*fart noise*",
                "`You pet the imp and it falls over.`",
                "*blarg*",
                "*Skaboo~*",
                "*fart noise*",
                "`You pet the imp and it falls over.`",
                "*blarg*",
                "*Skaboo~*",
                "*fart noise*",
                "`You pet the imp and it falls over.`",
                "*blarg*",
                "*Skaboo~*",
                "*fart noise*",
                "`You pet the imp and it falls over.`",
                "*blarg*",
                "*Skaboo~*",
                "*fart noise*",
                "`You pet the imp and it falls over.`",
                "*blarg*",
                "*Skaboo~*",
                "*fart noise*",
                "`You pet the imp and it falls over.`",
                "*blarg*",
                "*Skaboo~*",
                "*fart noise*",
                "`You pet the imp and it falls over.`",
                "You give the feather fur of the hairy imp an appreciative ruffle as you pet it on the head. The inp purrs happily and looks at you with eyes shining with gratitude. It seems you've made a friend."
            };


			rand = new Random();

			discord = new DiscordClient(x =>
			{
				x.LogLevel = LogSeverity.Info;
				x.LogHandler = Log;
			});

			discord.UsingCommands(x =>
			{
				x.PrefixChar = '~';
				x.AllowMentionPrefix = true;
			});

			var commands = discord.GetService<CommandService>();

            commands.CreateCommand("hello")
                .Do(async (e) =>
                {
                    int randomHelloMessage = rand.Next(helloMessages.Length);
                    string helloToSay = helloMessages[randomHelloMessage];
                    await e.Channel.SendMessage(helloToSay);
                });

            commands.CreateCommand("pet") //gay noxalas ligaratus
                .Do(async (e) =>
                {
                    int randomPetMessage = rand.Next(petMessages.Length);
                    string petToSay = petMessages[randomPetMessage];
                    await e.Channel.SendMessage(petToSay);
                    if (petToSay == "You give the feather fur of the hairy imp an appreciative ruffle as you pet it on the head. The inp purrs happily and looks at you with eyes shining with gratitude. It seems you've made a friend.")
                    {
                        System.Threading.Thread.Sleep(500);
                        int randomPetMessageImage = rand.Next(petMessageImages.Length);
                        string petMessageImageToSend = petMessageImages[randomPetMessageImage];
                        await e.Channel.SendFile(petMessageImageToSend);
                    };
                });

            commands.CreateCommand("insult manley") //gay noxalas ligaratus
                .Do(async (e) =>
                {
                    int randomManleyInsult = rand.Next(manleyInsults.Length);
                    string insultToSay = manleyInsults[randomManleyInsult];
                    await e.Channel.SendMessage(insultToSay);
                    if (insultToSay == "Manley, you son of a birhc")
                    {
                        System.Threading.Thread.Sleep(500);
                        await e.Channel.SendFile("photos/birhc.png");
                    };
                });

            commands.CreateCommand("Bound Together this will never be found ok so just stop trying")
				.Do(async (e) =>
				{
					await e.Channel.SendMessage("Their journey began");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("On a barren waste where the reader arrived");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Afraid and alone");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("When they arrived");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("The Book of Rites awakened the Nightwings");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("And ignited the flame");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**THEY FOLLOW THE STARS**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**BOUND TOGETHER**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**STRANDS IN A BRAID 'TIL THE END**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("We sing of the last");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Of the Nightwings who, having broken the cycle");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Shall life on in song");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Hedwyn was there");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("And proved to all that he was no deserter");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("He stayed true 'til the end");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Captian Jodariel");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Keeping watch over all of the Nightwings");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("She stayed true 'til the end");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Rukey Greentail");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Small in size but vast in commitment");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("He stayed true 'til the end");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**THEY FOLLOW THE STARS**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**BOUND TOGETHER**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**STRANDS IN A BRAID 'TIL THE END**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("The Moon-Touched Girl");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Hears the Scribes in the world all around her");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("She stayed true 'til the end");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Ti'zo the wise");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Ever faithful to the cause of the Nighwings");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("He stayed true 'til the end");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Sir Gilman the bold");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Ever in his quest, finding honor in glory");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("He stayed true 'til the end");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Pamitha Theyn");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Borne on guilty wings, ever seeking forgiveness");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("She stayed true 'til the end");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**THEY FOLLOW THE STARS**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**BOUND TOGETHER**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**STRANDS IN A BRAID 'TIL THE END**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Bound together");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Spirits tethered");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Strands unbroken");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Scribes awoken");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("The great mastermind");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Volfred Sandalwood saw his plans turn to action");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("He stayed true 'til the end");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("The bog-dweller Bertrude");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Kept her foes at bay with her finest enchantments");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("She stayed true 'til the end");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("The reader at last");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Made the Nightwings whole, having bound them together");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("They stayed true 'til the end");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**THEY FOLLOW THE STARS**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**BOUND TOGETHER**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**STRANDS IN A BRAID 'TIL THE END**");
					await e.Channel.SendMessage("**THEY FOLLOW THE STARS**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**BOUND TOGETHER**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("**STRANDS IN A BRAID 'TIL THE END**");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("Now at the end");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("As we bid farewell and return to the stars");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("We shall find our way home");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("We shall find our way home");
					System.Threading.Thread.Sleep(1000);
					await e.Channel.SendMessage("We shall find our way home...");
					await e.Channel.SendMessage("~Bound Together");
				});

			commands.CreateCommand("banne") 
				.Do(async (e) =>
				{
					await e.Channel.SendFile("photos/nobanne.png");
				});

            commands.CreateCommand("Bound Together")
            .Do(async (e) =>
            {
                await e.Channel.SendMessage(":banne:");
            });

            commands.CreateCommand("whomst")
			.Do(async (e) =>
			{
				await e.Channel.SendFile("photos/whomstdve.jpg");
			});

            commands.CreateCommand("pinne")
            .Do(async (e) =>
            {
                await e.Channel.SendFile("photos/pinne.png");
            });

            commands.CreateCommand("how do harp")
            .Do(async (e) =>
            {
                await e.Channel.SendFile("photos/feetguns.png");
            });

            commands.CreateCommand("cute")
            .Do(async (e) =>
            {
                await e.Channel.SendFile("photos/cute.png");
            });

            commands.CreateCommand("valid")
            .Do(async (e) =>
            {
                await e.Channel.SendMessage("The inp looks at you with doeful eyes and knows that you are the best in your own way at what you do.");
                await e.Channel.SendMessage("It gives you a hug and coos its belief in you.");
            });

            commands.CreateCommand("geg")
            .Do(async (e) =>
            {
                await e.Channel.SendFile("photos/geg.png");
            });

            commands.CreateCommand("talent")
            .Do(async (e) =>
            {
                await e.Channel.SendFile("photos/talent.png");
            });

            commands.CreateCommand("bague")
            .Do(async (e) =>
            {
                await e.Channel.SendMessage("`bague - the deep golden color of a freshly baked baguette`");
            });

            commands.CreateCommand("help")
            .Do(async (e) =>
            {
                await e.Channel.SendMessage("`hello - say hello to the inp`" + Environment.NewLine + "`valid - gives you confidence`" + Environment.NewLine + "`pet - pet the inp`" + Environment.NewLine + "`banne - no banne`" + Environment.NewLine + "`pinne - guess i'll pinne`" + Environment.NewLine + "`how do harp - shows how harps carry weapons`" + Environment.NewLine +
                    "`cute - Raven's cute litter of kitties`" + Environment.NewLine + "`geg - snart`" + Environment.NewLine + "`talent - raw, unfiltered talent`" + Environment.NewLine + "`bague - the best color`" + Environment.NewLine + "`no - no`" + Environment.NewLine + "`status - what the inp is doing at the moment`" + Environment.NewLine + "`Bound Together but not actually - haha secret command`" + Environment.NewLine + "`whomst - whom'd'stve`" + Environment.NewLine + 
                    "`First Veil - the copypasta reimagined`" + Environment.NewLine + "`insult Manley - what it says on the box`" + Environment.NewLine + "`waifu rating - see how good of a waifu our resident inp is`");
            });


            commands.CreateCommand("no") //Red
				.Do(async (e) =>
				{
					int randomNoIndex = rand.Next(redSayingNo.Length);
					string noToPost = redSayingNo[randomNoIndex];
					await e.Channel.SendFile(noToPost);
				});

            commands.CreateCommand("status")
                .Do(async (e) =>
                {
                    int randomStatusIndex = rand.Next(statusMessages.Length);
                    string statusToPost = statusMessages[randomStatusIndex];
                    await e.Channel.SendMessage(statusToPost);
                });

            commands.CreateCommand("waifu rating")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("photos/waifurating.png");
                });

            commands.CreateCommand("First Veil")
            .Do(async (e) =>
            {
                await e.Channel.SendMessage("`What the fuck did you just fucking say about me, you little exile? I’ll have you know I graduated top of my class in the Liberation Rites, and I’ve been involved in numerous secret raids on the Commonwealth and I have over 300 confirmed Pyre dousings. I am trained in Scribe warfare and I’m the top aura blaster in the entire Nightwings entourage. You are nothing to me but just another target. I will wipe you the fuck out with precision the likes of which has never been seen before in the Downside, mark my fucking words. You think you can get away with saying that shit to me over the Reader’s Telepathy? Think again, fucker. As we speak I am contacting my secret network of spies across the Sahrian Union and your Blackwagon is being traced right now so you better prepare for the storm, Wyrm. The storm that wipes out the pathetic little thing you call your Pyre. You’re fucking dead, kid. I can be anywhere, anytime, and I can crossmap you in over seven hundred ways, and that’s just with my Presence Aura. Not only am I extensively trained in Linking Auras, but I have access to the entire arsenal of the Eight Scribes Masteries and I will use it to its full extent to wipe your miserable ass off the face of the Downside, you little shit. If only you could have known what unholy retribution your little “clever” comment was about to bring down upon you, maybe you would have held your fucking tongue. But you couldn’t, you didn’t, and now you’re paying the price, you goddamn idiot. I will shit fury all over you and you will drown in it. You’re fucking dead, Exile.`");
            });

            //commands.CreateCommand("channelDebug")
            //	.Do(async (e) =>
            //	{
            //	await e.Channel.SendMessage(e.Channel);
            //	});

            discord.ExecuteAndWait(async () =>
			{
				await discord.Connect("MzQzODkyMTUxMjUzNDY3MTQ3.DGlfcg.wEU9IABOhvnwFm0Sya4_Zglo7KU", TokenType.Bot);
			});
		}

		private void Log(object sender, LogMessageEventArgs e)
		{
			Console.WriteLine(e.Message);
		}
	}
}
