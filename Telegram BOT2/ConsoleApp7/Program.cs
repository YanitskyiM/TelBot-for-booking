using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.ReplyMarkups;

using Telegram.Bot.Types;
using System.Threading;

class Program
{

    
    private static readonly TelegramBotClient Bot = new TelegramBotClient("794936603:AAEaN6MGpJG6SKlUbrwykNOVnfogMKfd330") { Timeout = TimeSpan.FromSeconds(10) };
    

    static void Main(string[] args)
    {
        
        Bot.OnMessage += Message;

        var me = Bot.GetMeAsync().Result;

        Console.WriteLine(me.Username);
        
        Bot.StartReceiving();
        while (true) { }
    }
    public static long ChatID;

  
    private static void Message(object sender, MessageEventArgs messageEventArgs)
    {
        var message = messageEventArgs.Message;
        
        if (message == null) return;
        

        
        if (message.Text.StartsWith("/start"))
        {
            var keyboard = new ReplyKeyboardMarkup(new[]
            {
                    new [] // 1
                    {
                        new KeyboardButton("Male"),
                         new KeyboardButton("Female")
                    }
            });

            Bot.SendTextMessageAsync(message.Chat.Id, "Choose you geneder", replyMarkup: keyboard);
        }

        if (message.Text.StartsWith("Male"))
        {
            var keyboard1 = new ReplyKeyboardMarkup(new[]
            {new [] // 1
                    { new KeyboardButton("George Hroshev") },
             new []
                    { new KeyboardButton("Valeriy Nukolushun")},
             new []
                    { new KeyboardButton("Andriy Pavliuk")}
            });
            Bot.SendTextMessageAsync(message.Chat.Id, "Choose free hairdresser", replyMarkup: keyboard1);
        }
        if (message.Text.StartsWith("George Hroshev"))
        {

            Bot.SendTextMessageAsync(message.Chat.Id, "Done, here is his number, please call him \n 0957826485");
        }
        if (message.Text.StartsWith("Valeriy Nukolushun"))
        {

            Bot.SendTextMessageAsync(message.Chat.Id, "Done, here is his number, please call him \n 0457826463");
        }
        if (message.Text.StartsWith("Andriy Pavliuk"))
        {

            Bot.SendTextMessageAsync(message.Chat.Id, "Done, here is his number, please call him \n 0657826435");
        }

        if (message.Text.StartsWith("Female"))
        {
            var keyboard2 = new ReplyKeyboardMarkup(new[]
            {new [] // 1
                    { new KeyboardButton("Nina Sokolova") },
             new []
                    { new KeyboardButton("Anna Samoshod")},
             new []
                    { new KeyboardButton("Angelika Rulska")},
             new []
                    { new KeyboardButton("Irina Yanovska")}
            });

            Bot.SendTextMessageAsync(message.Chat.Id, "Choose free hairdresser", replyMarkup: keyboard2);
        }
        if (message.Text.StartsWith("Nina Sokolova"))
        {

            Bot.SendTextMessageAsync(message.Chat.Id, "Done, here is her number, please call her \n 0957826498");
        }
        if (message.Text.StartsWith("Anna Samoshod"))
        {

            Bot.SendTextMessageAsync(message.Chat.Id, "Done, here is her number, please call her \n 0997826499");
        }
        if (message.Text.StartsWith("Angelika Rulska"))
        {

            Bot.SendTextMessageAsync(message.Chat.Id, "Done, here is her number, please call her \n 0957826444");
        }
        if (message.Text.StartsWith("Irina Yanovska"))
        {

            Bot.SendTextMessageAsync(message.Chat.Id, "Done, here is her number, please call her \n 0637826332");
        }

        if (message.Text.StartsWith("/adress"))
        {

            Bot.SendTextMessageAsync(message.Chat.Id, "Our hair salon located on the st. Taras Bulba 37/A");
        }




        if (message.Text.StartsWith("/information"))
        {

            Bot.SendTextMessageAsync(message.Chat.Id, "Hi, i have been developed by Yanitskyi");
        }

        if (message.Text.StartsWith("/help"))
        {

            Bot.SendTextMessageAsync(message.Chat.Id, "If you have some question you can contact us by this number \n0957158025 , " +
                "or write on this \ne-mail my_barbershop@gmail.com  ");
        }

        if (message.Text.StartsWith("/discount"))
        {
            var keyboard3 = new ReplyKeyboardMarkup(new[]
                        {
                    new [] // 1
                    {
                        new KeyboardButton("1"),
                         new KeyboardButton("2")
                    }
            });

            Bot.SendTextMessageAsync(message.Chat.Id, "Choose number", replyMarkup: keyboard3);
        }
        if (message.Text.StartsWith("1"))
        {

            Bot.SendTextMessageAsync(message.Chat.Id, "Congratulation, say 'Sponge Bob' in our salon and get discount for 50%");
        }
        if (message.Text.StartsWith("2"))
        {

            Bot.SendTextMessageAsync(message.Chat.Id, "Sorry, you didn't guess, and don't get a discount");
        }
    }
 }

    