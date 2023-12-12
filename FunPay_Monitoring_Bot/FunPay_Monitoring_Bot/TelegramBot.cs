using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;
using System;

namespace FunPay_Monitoring_Bot
{
    internal class TelegramBot
    {
        static string datetime = DateTime.Now.ToString("dd MM yyyy  HH:mm"); 
        static string Token = "6445252657:AAHmVCFSnuu0rGqTNQlllTrjHIStPhpQcEk";
        static ITelegramBotClient bot = new TelegramBotClient(Token);
        private static string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);


        public static void Start()
        {

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { },
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );

        }

        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.CallbackQuery) // скорее всего кнопки
            {
                await HandleCallbackQuery(botClient, update.CallbackQuery);
                return;
            }
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message) // сообщение
            {
                var message = update.Message;
                Console.WriteLine(DateTime.Now.ToString("dd.MM  H:mm") + " - " + message.From.Username + "  " + message.Text);

                if (message.Text != null)
                {
                    TelegramBot topDay = new TelegramBot();

                    if (message.Text == "/start")
                    {

                        var replyKeyboard = new ReplyKeyboardMarkup(
                                    new List<KeyboardButton[]>()
                                    {
                                        new KeyboardButton[]
                                        {
                                            new KeyboardButton("Топ продавцов за день"),
                                            new KeyboardButton("Топ продавцов за все время"),
                                        },
                                        new KeyboardButton[]
                                        {
                                            new KeyboardButton("Всего продано за все время")
                                        }
                                    })
                        {
                            ResizeKeyboard = true,
                        };

                        await bot.SendTextMessageAsync(message.Chat.Id, "*Бот по мониторингу продаж на Funpay*\n\n" +
                            "*Все данные могут отличаться от реальных показателей продаж, но они максимально приближены к реальности насколько это возможно в текущих условиях\n\n*" +
                            $"*Мониторинг ведется с {datetime}*",
                            parseMode: Telegram.Bot.Types.Enums.ParseMode.MarkdownV2,
                            replyMarkup: replyKeyboard);
                    }

                        if (message.Text == "Топ продавцов за день")
                    {
                        
                        string ans = topDay.TopDay();
                        await bot.SendTextMessageAsync(message.Chat.Id, ans, parseMode: Telegram.Bot.Types.Enums.ParseMode.MarkdownV2);
                        
                        
                    }

                    if (message.Text == "Топ продавцов за все время")
                    {
                        string ans = topDay.TopTotal();
                        await bot.SendTextMessageAsync(message.Chat.Id, ans, parseMode: Telegram.Bot.Types.Enums.ParseMode.MarkdownV2);
                    }
                    
                    if(message.Text == "Всего продано за все время")
                    {
                        string ans = topDay.AllTotal();
                        await bot.SendTextMessageAsync(message.Chat.Id, ans, parseMode: Telegram.Bot.Types.Enums.ParseMode.MarkdownV2);
                    }
                    
                    else { }
                    
                }
            }
        }
        public static async Task HandleCallbackQuery(ITelegramBotClient botClient, CallbackQuery callback)
        {

        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }
        public string TopDay()
        {
            Dictionary<string, int> users = new Dictionary<string, int>
            {
                
                { "Tape27", Program.Tape27_day },
                { "destorsh", Program.destorsh_day },
                { "Slashee", Program.Slashee_day },
                { "Mashs8" , Program.Mashs8_day},
                { "gilzzz", Program.gilzzz_day },
                { "chimadima1", Program.chimadima1_day },
                { "Pe4alika", Program.Pe4alika_day },
                { "Maksim1214", Program.Maksim1214_day },
                { "Lovew", Program.Lovew_day },
                { "elektra28", Program.elektra28_day },
                { "grawaboy9", Program.grawaboy9_day },
                { "domindal", Program.domindal_day },
                { "Savelentino", Program.Savelentino_day },
                { "Karls0m", Program.Karls0m_day },
                { "waka33", Program.waka33_day },
                { "TopCapybaraShop", Program.TopCapybaraShop_day },
                { "Lame1339",Program.Lame1339_day },
                { "Anturazhniy1", Program.Anturazhniy1_day },
                { "Sandaliki777", Program.Sandaliki777_day },
                { "nikitkavaibmen", Program.nikitkavaibmen_day },
                { "ty0mych", Program.ty0mych_day },
                { "taksafr", Program.taksafr_day },
                { "ReinWay", Program.ReinWay_day },
                { "Meteor333", Program.Meteor333_day },
                { "Mtvitv", Program.Mtvitv_day },
                { "canek52", Program.canek52_day },
                { "Ilyxagg", Program.Ilyxagg_day },
                

            };
            int[] array_count = new int[5];
            string[] array_name = new string[5];

            for (int i = 0; i < 5; i++)
            {
                foreach (var user in users)
                {
                    if (array_count[i] < user.Value)
                    {
                        array_count[i] = user.Value;
                        array_name[i] = user.Key;
                        
                    }
                }
                try { users.Remove(array_name[i]); } catch { }

            }

            return $"*Топ 5 продавцов за день*\n" +
                $"1️⃣ *{array_name[0]} продал {array_count[0]}* \n" +
                $"2️⃣ *{array_name[1]} продал {array_count[1]}* \n" +
                $"3️⃣ *{array_name[2]} продал {array_count[2]}* \n" +
                $"4️⃣ *{array_name[3]} продал {array_count[3]}* \n" +
                $"5️⃣ *{array_name[4]} продал {array_count[4]}* \n";
                
               
        }
        public string TopTotal()
        {
            string[] array_users = { "canek52", "Tape27", "destorsh", "Slashee", "Mashs8", "gilzzz", "chimadima1",
                "Pe4alika", "Maksim1214", "Lovew", "elektra28", "grawaboy9", "domindal", "Savelentino",
                "Karls0m", "waka33", "TopCapybaraShop", "Lame1339","Anturazhniy1", "Sandaliki777", "nikitkavaibmen",
                "ty0mych", "taksafr", "ReinWay", "Meteor333", "Mtvitv", "Ilyxagg"};

            int[] array_total = new int[5];
            string[] array_name = new string[5];
            int temp = 0;
            int index = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int x = 0; x < array_users.Length; x++)
                {
                    if (array_users[x] == "delete") { continue; }

                    using (StreamReader sr = new StreamReader(path + @$"/users/{array_users[x]}/{array_users[x]}_total.txt"))
                    {
                        temp = Convert.ToInt32(sr.ReadLine());

                        if (array_total[i] < temp)
                        {
                            array_total[i] = temp;
                            array_name[i] = array_users[x];
                            index = x;
                        }

                    }
                }
                array_users[index] = "delete";

            }

            return $"*Топ 5 продавцов за все время*\n" +
                $"1️⃣ *{array_name[0]} продал {array_total[0]}* \n" +
                $"2️⃣ *{array_name[1]} продал {array_total[1]}* \n" +
                $"3️⃣ *{array_name[2]} продал {array_total[2]}* \n" +
                $"4️⃣ *{array_name[3]} продал {array_total[3]}* \n" +
                $"5️⃣ *{array_name[4]} продал {array_total[4]}* \n";
        }
        public string AllTotal()
        {
            string[] array_users = { "canek52", "Tape27", "destorsh", "Slashee", "Mashs8", "gilzzz", "chimadima1",
                "Pe4alika", "Maksim1214", "Lovew", "elektra28", "grawaboy9", "domindal", "Savelentino",
                "Karls0m", "waka33", "TopCapybaraShop", "Lame1339","Anturazhniy1", "Sandaliki777", "nikitkavaibmen",
                "ty0mych", "taksafr", "ReinWay", "Meteor333", "Mtvitv", "Ilyxagg"};

            int sum = 0;
            for (int i = 0; i < array_users.Length; i++)
            {
                using (StreamReader sr = new StreamReader(path + @$"/users/{array_users[i]}/{array_users[i]}_total.txt"))
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
            }

            return "*Продаж за все время*\n" +
                $"*{sum}*";
        }
    }
}
