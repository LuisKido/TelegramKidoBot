using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramKidoBot
{
    class Program
    {

        private static readonly TelegramBotClient bot = new TelegramBotClient(""); //API token de tu bot aqui.
        static void Main(string[] args)
        {
            bot.OnMessage += Bot_OnMessage;

            bot.OnMessageEdited += Bot_OnMessage;

            bot.StartReceiving();
            Console.ReadLine();
            bot.StopReceiving();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {

            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                if (e.Message.Text == "!upa")
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Chalupa! " + e.Message.Chat.Username);
                }
                else
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, @"Usage : 
                    !upa
                    ");
                }
            }
        }
    }
}
