using System.Net;

namespace FunPay_Monitoring_Bot
{
    internal class Program
    {
        private static string Token = "6445252657:AAHmVCFSnuu0rGqTNQlllTrjHIStPhpQcEk";

        static int day_now = DateTime.Now.Day;

        static Monitoring mon_taksafr_1 = new Monitoring(1);
        static Monitoring mon_taksafr_2 = new Monitoring(2);
        public static int taksafr_day = 0;

        static Monitoring mon_Tape27_1 = new Monitoring(1);
        static Monitoring mon_Tape27_2 = new Monitoring(2);
        public static int Tape27_day = 0;

        static Monitoring mon_ty0mych_1 = new Monitoring(1);
        static Monitoring mon_ty0mych_2 = new Monitoring(2);
        static Monitoring mon_ty0mych_3 = new Monitoring(3);
        public static int ty0mych_day = 0;

        static Monitoring mon_Maksim1214_1 = new Monitoring(1);
        static Monitoring mon_Maksim1214_2 = new Monitoring(2);
        public static int Maksim1214_day = 0;

        static Monitoring mon_nikitkavaibmen_1 = new Monitoring(1);
        static Monitoring mon_nikitkavaibmen_2 = new Monitoring(2);
        static Monitoring mon_nikitkavaibmen_3 = new Monitoring(3);
        static Monitoring mon_nikitkavaibmen_4 = new Monitoring(4);
        static Monitoring mon_nikitkavaibmen_5 = new Monitoring(5);
        static Monitoring mon_nikitkavaibmen_6 = new Monitoring(6);
        public static int nikitkavaibmen_day = 0;

        static Monitoring mon_Sandaliki777_1 = new Monitoring(1);
        public static int Sandaliki777_day = 0;

        static Monitoring mon_Anturazhniy1_1 = new Monitoring(1);
        public static int Anturazhniy1_day = 0;

        static Monitoring mon_Lame1339_1 = new Monitoring(1);
        public static int Lame1339_day = 0;

        static Monitoring mon_TopCapybaraShop_1 = new Monitoring(1);
        public static int TopCapybaraShop_day = 0;

        static Monitoring mon_Ilyxagg_1 = new Monitoring(1);
        static Monitoring mon_Ilyxagg_2 = new Monitoring(2);
        static Monitoring mon_Ilyxagg_3 = new Monitoring(3);
        static Monitoring mon_Ilyxagg_4 = new Monitoring(4);
        public static int Ilyxagg_day = 0;

        static Monitoring mon_waka33_1 = new Monitoring(1);
        static Monitoring mon_waka33_2 = new Monitoring(2);
        static Monitoring mon_waka33_3 = new Monitoring(3);
        static Monitoring mon_waka33_4 = new Monitoring(4);
        public static int waka33_day = 0;

        static Monitoring mon_Karls0m_1 = new Monitoring(1);
        public static int Karls0m_day = 0;

        static Monitoring mon_Savelentino_1 = new Monitoring(1);
        public static int Savelentino_day = 0;

        static Monitoring mon_destorsh_1 = new Monitoring(1);
        public static int destorsh_day = 0;

        static Monitoring mon_domindal_1 = new Monitoring(1);
        static Monitoring mon_domindal_2 = new Monitoring(2);
        static Monitoring mon_domindal_3 = new Monitoring(3);
        static Monitoring mon_domindal_4 = new Monitoring(4);
        static Monitoring mon_domindal_5 = new Monitoring(5);
        public static int domindal_day = 0;

        static Monitoring mon_grawaboy9_1 = new Monitoring(1);
        static Monitoring mon_grawaboy9_2 = new Monitoring(2);
        public static int grawaboy9_day = 0;

        static Monitoring mon_elektra28_1 = new Monitoring(1);
        public static int elektra28_day = 0;

        static Monitoring mon_Slashee_1 = new Monitoring(1);
        static Monitoring mon_Slashee_2 = new Monitoring(2);
        static Monitoring mon_Slashee_3 = new Monitoring(3);
        static Monitoring mon_Slashee_4 = new Monitoring(4);
        static Monitoring mon_Slashee_5 = new Monitoring(5);
        static Monitoring mon_Slashee_6 = new Monitoring(6);
        static Monitoring mon_Slashee_7 = new Monitoring(7);
        static Monitoring mon_Slashee_8 = new Monitoring(8);
        static Monitoring mon_Slashee_9 = new Monitoring(9);
        public static int Slashee_day = 0;

        static Monitoring mon_Lovew_1 = new Monitoring(1);
        static Monitoring mon_Lovew_2 = new Monitoring(2);
        static Monitoring mon_Lovew_3 = new Monitoring(3);
        static Monitoring mon_Lovew_4 = new Monitoring(4);
        static Monitoring mon_Lovew_5 = new Monitoring(5);
        static Monitoring mon_Lovew_6 = new Monitoring(6);
        static Monitoring mon_Lovew_7 = new Monitoring(7);
        static Monitoring mon_Lovew_8 = new Monitoring(8);
        public static int Lovew_day = 0;

        static Monitoring mon_ReinWay_1 = new Monitoring(1);
        public static int ReinWay_day = 0;

        static Monitoring mon_Pe4alika_1 = new Monitoring(1);
        static Monitoring mon_Pe4alika_2 = new Monitoring(2);
        public static int Pe4alika_day = 0;

        static Monitoring mon_chimadima1_1 = new Monitoring(1);
        public static int chimadima1_day = 0;

        static Monitoring mon_gilzzz_1 = new Monitoring(1);
        public static int gilzzz_day = 0;

        static Monitoring mon_Mashs8_1 = new Monitoring(1);
        public static int Mashs8_day = 0;

        static Monitoring mon_Meteor333_1 = new Monitoring(1);
        public static int Meteor333_day = 0;

        static Monitoring mon_Mtvitv_1 = new Monitoring(1);
        public static int Mtvitv_day = 0;

        static Monitoring mon_canek52_1 = new Monitoring(1);
        public static int canek52_day = 0;


        static void Main(string[] args)
        {
            Thread botAsync = new Thread(TelegramBot.Start);
            botAsync.Start();

            int iteration = 0;

            while (true)
            {


                Send_Notification(iteration.ToString());

                Mtvitv();
                Slashee();
                Meteor333();
                canek52();
                Mashs8();
                gilzzz();
                chimadima1();
                Pe4alika();
                Maksim1214();
                Lovew();
                elektra28();
                grawaboy9();
                domindal();
                destorsh();
                Savelentino();
                Karls0m();
                waka33();
                Ilyxagg();
                TopCapybaraShop();
                Lame1339();
                Anturazhniy1();
                Sandaliki777();
                nikitkavaibmen();
                ty0mych();
                Tape27();
                taksafr();
                ReinWay();


                if (day_now != DateTime.Now.Day) // если новый день
                {
                    SaveInfo();
                    day_now = DateTime.Now.Day;
                }

                iteration++;
            }
        }
        public static void Send_Notification(string message)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://api.telegram.org/bot{Token}/sendMessage?text={message}&chat_id=620080242");
                request.Method = "GET";
                request.Headers.Add("sec-ch-ua: \"Chromium\";v=\"116\", \"Not)A;Brand\";v=\"24\", \"Google Chrome\";v=\"116\"");
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7";
                request.Headers.Add("sec-ch-ua-mobile: ?0");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36";
                request.Headers.Add("sec-ch-ua-platform: \"Windows\"");
                request.Headers.Add("Upgrade-Insecure-Requests: 1");
                request.Headers.Add("Sec-Fetch-Site: same-origin");
                request.Headers.Add("Sec-Fetch-Mode: navigate");
                request.Headers.Add("Sec-Fetch-User: ?1");
                request.Headers.Add("Sec-Fetch-Dest: document");
                request.Headers.Add("Accept-Language: ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
                request.Headers.Add("Cookie: stel_ln=ru");
                request.Headers.Add("Accept-Encoding: gzip, deflate");
                request.AutomaticDecompression = DecompressionMethods.GZip;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());
                var html = reader.ReadToEnd();
            }
            catch { }
        }

        /* Правила добавления нового продавца
         * 1. Метод с монитором
         * 2. Объект класса
         * 3. Добавить метод в main
         * 4. Добавить в SaveInfo
         * 5. Создать папку и txt
         * 6. Telegrambot 3 метода
        */

        public static void SaveInfo()
        {

            Update_bases.Update_day("canek52", canek52_day, day_now); canek52_day = 0;
            Update_bases.Update_day("Mtvitv", Mtvitv_day, day_now); Mtvitv_day = 0;
            Update_bases.Update_day("Mashs8", Mashs8_day, day_now); Mashs8_day = 0;
            Update_bases.Update_day("Meteor333", Meteor333_day, day_now); Meteor333_day = 0;
            Update_bases.Update_day("gilzzz", gilzzz_day, day_now); gilzzz_day = 0;
            Update_bases.Update_day("chimadima1", chimadima1_day, day_now); chimadima1_day = 0;
            Update_bases.Update_day("Pe4alika", Pe4alika_day, day_now); Pe4alika_day = 0;
            Update_bases.Update_day("ReinWay", ReinWay_day, day_now); ReinWay_day = 0;
            Update_bases.Update_day("Maksim1214", Maksim1214_day, day_now); Maksim1214_day = 0;
            Update_bases.Update_day("Slashee", Slashee_day, day_now); Slashee_day = 0;
            Update_bases.Update_day("Lovew", Lovew_day, day_now); Lovew_day = 0;
            Update_bases.Update_day("elektra28", elektra28_day, day_now); elektra28_day = 0;
            Update_bases.Update_day("grawaboy9", grawaboy9_day, day_now); grawaboy9_day = 0;
            Update_bases.Update_day("domindal", domindal_day, day_now); domindal_day = 0;
            Update_bases.Update_day("destorsh", destorsh_day, day_now); destorsh_day = 0;
            Update_bases.Update_day("Savelentino", Savelentino_day, day_now); Savelentino_day = 0;
            Update_bases.Update_day("Karls0m", Karls0m_day, day_now); Karls0m_day = 0;
            Update_bases.Update_day("waka33", waka33_day, day_now); waka33_day = 0;
            Update_bases.Update_day("Ilyxagg", Ilyxagg_day, day_now); Ilyxagg_day = 0;
            Update_bases.Update_day("TopCapybaraShop", TopCapybaraShop_day, day_now); TopCapybaraShop_day = 0;
            Update_bases.Update_day("Lame1339", Lame1339_day, day_now); Lame1339_day = 0;
            Update_bases.Update_day("Anturazhniy1", Anturazhniy1_day, day_now); Anturazhniy1_day = 0;
            Update_bases.Update_day("Sandaliki777", Sandaliki777_day, day_now); Sandaliki777_day = 0;
            Update_bases.Update_day("nikitkavaibmen", nikitkavaibmen_day, day_now); nikitkavaibmen_day = 0;
            Update_bases.Update_day("ty0mych", ty0mych_day, day_now); ty0mych_day = 0;
            Update_bases.Update_day("Tape27", Tape27_day, day_now); Tape27_day = 0;
            Update_bases.Update_day("taksafr", taksafr_day, day_now); taksafr_day = 0;
        }
        
        public static void canek52()
        {
            canek52_day += mon_canek52_1.Monitor("canek52", "https://funpay.com/lots/offer?id=23610069");
        }
        public static void Mtvitv()
        {
            Mtvitv_day += mon_Mtvitv_1.Monitor("Mtvitv", "https://funpay.com/lots/offer?id=24084979");
        }
        public static void Meteor333()
        {
            Meteor333_day += mon_Meteor333_1.Monitor("Meteor333", "https://funpay.com/lots/offer?id=24157344");
        }
        public static void Mashs8()
        {
            Mashs8_day += mon_Mashs8_1.Monitor("Mashs8", "https://funpay.com/lots/offer?id=24107674");
        }
        public static void gilzzz()
        {
            gilzzz_day += mon_gilzzz_1.Monitor("gilzzz", "https://funpay.com/lots/offer?id=24038545");
        }
        public static void chimadima1()
        {
            chimadima1_day += mon_chimadima1_1.Monitor("chimadima1", "https://funpay.com/lots/offer?id=23551059");
        }
        public static void Pe4alika()
        {
            Pe4alika_day += mon_Pe4alika_1.Monitor("Pe4alika", "https://funpay.com/lots/offer?id=23694939");
            Pe4alika_day += mon_Pe4alika_2.Monitor("Pe4alika", "https://funpay.com/lots/offer?id=23694756");
        }
        public static void ReinWay()
        {
            ReinWay_day += mon_ReinWay_1.Monitor("ReinWay", "https://funpay.com/lots/offer?id=23888346");
        }
        public static void Slashee()
        {
            Slashee_day += mon_Slashee_1.Monitor("Slashee", "https://funpay.com/lots/offer?id=23904077");
            Slashee_day += mon_Slashee_2.Monitor("Slashee", "https://funpay.com/lots/offer?id=23682878");
            Slashee_day += mon_Slashee_3.Monitor("Slashee", "https://funpay.com/lots/offer?id=23657556");
            Slashee_day += mon_Slashee_4.Monitor("Slashee", "https://funpay.com/lots/offer?id=23631064");
            Slashee_day += mon_Slashee_5.Monitor("Slashee", "https://funpay.com/lots/offer?id=23631029");
            Slashee_day += mon_Slashee_6.Monitor("Slashee", "https://funpay.com/lots/offer?id=23630361");
            Slashee_day += mon_Slashee_7.Monitor("Slashee", "https://funpay.com/lots/offer?id=24022552");
            Slashee_day += mon_Slashee_8.Monitor("Slashee", "https://funpay.com/lots/offer?id=23682854");
            Slashee_day += mon_Slashee_9.Monitor("Slashee", "https://funpay.com/lots/offer?id=23630331");
        }
        public static void Lovew()
        {
            Lovew_day += mon_Lovew_1.Monitor("Lovew", "https://funpay.com/lots/offer?id=23968097");
            Lovew_day += mon_Lovew_2.Monitor("Lovew", "https://funpay.com/lots/offer?id=23959560");
            Lovew_day += mon_Lovew_3.Monitor("Lovew", "https://funpay.com/lots/offer?id=23959544");
            Lovew_day += mon_Lovew_4.Monitor("Lovew", "https://funpay.com/lots/offer?id=23959533");
            Lovew_day += mon_Lovew_5.Monitor("Lovew", "https://funpay.com/lots/offer?id=23949486");
            Lovew_day += mon_Lovew_6.Monitor("Lovew", "https://funpay.com/lots/offer?id=23949386");
            Lovew_day += mon_Lovew_7.Monitor("Lovew", "https://funpay.com/lots/offer?id=23949253");
            Lovew_day += mon_Lovew_8.Monitor("Lovew", "https://funpay.com/lots/offer?id=23949300");
        }
        public static void elektra28()
        {
            elektra28_day += mon_elektra28_1.Monitor("elektra28", "https://funpay.com/lots/offer?id=23842268");
        }
        public static void grawaboy9()
        {
            grawaboy9_day += mon_grawaboy9_1.Monitor("grawaboy9", "https://funpay.com/lots/offer?id=23367205");
            grawaboy9_day += mon_grawaboy9_2.Monitor("grawaboy9", "https://funpay.com/lots/offer?id=23299551");
        }
        public static void domindal()
        {
            domindal_day += mon_domindal_1.Monitor("domindal", "https://funpay.com/lots/offer?id=23889674");
            domindal_day += mon_domindal_2.Monitor("domindal", "https://funpay.com/lots/offer?id=23856238");
            domindal_day += mon_domindal_3.Monitor("domindal", "https://funpay.com/lots/offer?id=23827521");
            domindal_day += mon_domindal_4.Monitor("domindal", "https://funpay.com/lots/offer?id=23762154");
            domindal_day += mon_domindal_5.Monitor("domindal", "https://funpay.com/lots/offer?id=23761960");
        }
        public static void destorsh()
        {
            destorsh_day += mon_destorsh_1.Monitor("destorsh", "https://funpay.com/lots/offer?id=23763195");
        }
        public static void Savelentino()
        {
            Savelentino_day += mon_Savelentino_1.Monitor("Savelentino", "https://funpay.com/lots/offer?id=23900481");
        }
        public static void Karls0m()
        {
            Karls0m_day += mon_Karls0m_1.Monitor("Karls0m", "https://funpay.com/lots/offer?id=23953691");
        }
        public static void waka33()
        {
            waka33_day += mon_waka33_1.Monitor("waka33", "https://funpay.com/lots/offer?id=23926517");
            waka33_day += mon_waka33_2.Monitor("waka33", "https://funpay.com/lots/offer?id=23151764");
            waka33_day += mon_waka33_3.Monitor("waka33", "https://funpay.com/lots/offer?id=23151490");
            waka33_day += mon_waka33_4.Monitor("waka33", "https://funpay.com/lots/offer?id=23151151");
        }
        public static void Ilyxagg()
        {
            Ilyxagg_day += mon_Ilyxagg_1.Monitor("Ilyxagg", "https://funpay.com/lots/offer?id=24137970");
            Ilyxagg_day += mon_Ilyxagg_2.Monitor("Ilyxagg", "https://funpay.com/lots/offer?id=24122935");
            Ilyxagg_day += mon_Ilyxagg_3.Monitor("Ilyxagg", "https://funpay.com/lots/offer?id=24122585");
            Ilyxagg_day += mon_Ilyxagg_4.Monitor("Ilyxagg", "https://funpay.com/lots/offer?id=24122403");
        }
        public static void TopCapybaraShop()
        {
            TopCapybaraShop_day += mon_TopCapybaraShop_1.Monitor("TopCapybaraShop", "https://funpay.com/lots/offer?id=23330519");
        }
        public static void Lame1339()
        {
            Lame1339_day += mon_Lame1339_1.Monitor("Lame1339", "https://funpay.com/lots/offer?id=23949660");
        }
        public static void Anturazhniy1()
        {
            Anturazhniy1_day += mon_Anturazhniy1_1.Monitor("Anturazhniy1", "https://funpay.com/lots/offer?id=23947977");
        }
        public static void Sandaliki777()
        {
            Sandaliki777_day += mon_Sandaliki777_1.Monitor("Sandaliki777", "https://funpay.com/lots/offer?id=23939064");
        }
        public static void nikitkavaibmen()
        {
            nikitkavaibmen_day += mon_nikitkavaibmen_1.Monitor("nikitkavaibmen", "https://funpay.com/lots/offer?id=23929593");
            nikitkavaibmen_day += mon_nikitkavaibmen_2.Monitor("nikitkavaibmen", "https://funpay.com/lots/offer?id=23929581");
            nikitkavaibmen_day += mon_nikitkavaibmen_3.Monitor("nikitkavaibmen", "https://funpay.com/lots/offer?id=23973289");
            nikitkavaibmen_day += mon_nikitkavaibmen_4.Monitor("nikitkavaibmen", "https://funpay.com/lots/offer?id=23958354");
            nikitkavaibmen_day += mon_nikitkavaibmen_5.Monitor("nikitkavaibmen", "https://funpay.com/lots/offer?id=23892218");
            nikitkavaibmen_day += mon_nikitkavaibmen_6.Monitor("nikitkavaibmen", "https://funpay.com/lots/offer?id=23892174");
        }
        public static void Maksim1214()
        {
            Maksim1214_day += mon_Maksim1214_1.Monitor("Maksim1214", "https://funpay.com/lots/offer?id=23694962");
            Maksim1214_day += mon_Maksim1214_2.Monitor("Maksim1214", "https://funpay.com/lots/offer?id=23694919");
        }
        public static void ty0mych()
        {
            ty0mych_day += mon_ty0mych_1.Monitor("ty0mych", "https://funpay.com/lots/offer?id=23951501");
            ty0mych_day += mon_ty0mych_2.Monitor("ty0mych", "https://funpay.com/lots/offer?id=23933535");
            ty0mych_day += mon_ty0mych_3.Monitor("ty0mych", "https://funpay.com/lots/offer?id=23889101");
        }
        public static void Tape27()
        {
            Tape27_day += mon_Tape27_1.Monitor("Tape27", "https://funpay.com/lots/offer?id=23296356");
            Tape27_day += mon_Tape27_2.Monitor("Tape27", "https://funpay.com/lots/offer?id=22164367");
        }
        public static void taksafr()
        {
            taksafr_day += mon_taksafr_1.Monitor("taksafr", "https://funpay.com/lots/offer?id=23470385");
            taksafr_day += mon_taksafr_2.Monitor("taksafr", "https://funpay.com/lots/offer?id=23470408");
        }
    }
}