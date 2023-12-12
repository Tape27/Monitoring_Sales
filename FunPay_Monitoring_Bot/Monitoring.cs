using System.Net;
using System.Reflection;

namespace FunPay_Monitoring_Bot
{
    internal class Monitoring
    {
        public int Id { get; set; }
        private static string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        public int user_count = 99;
        

        public Monitoring(int id) 
        { 
            Id = id;
        }

        public int Monitor(string name, string link)
        {
            Thread.Sleep(5000);
            int count_akk = 0;
            string html = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);


            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var stream = response.GetResponseStream();
                var reader = new StreamReader(stream);
                html = reader.ReadToEnd();
            }
            catch 
            {

                if (user_count == 1)
                {
                    using (StreamWriter sw = File.AppendText(path + @$"/users/{name}/{name}_log.txt"))
                    {
                        sw.WriteLine(DateTime.Now.ToString("dd.MM.yyyy - HH:mm") + " - Продажа аккаунта " + user_count + " штук" + " id " + Id);

                    }
                    SaveTotalSell(name, user_count);
                    user_count = 99;
                    return 1;
                }

                using (StreamWriter sw = File.AppendText(path + @$"/users/{name}/{name}_log.txt"))
                {
                    sw.WriteLine(DateTime.Now.ToString("dd.MM.yyyy - HH:mm") + " - Объявление неактивно" + " id " + Id);
                    
                }

                return 0;
            } // 404 предложение неактивно

            Parsing parsing = new Parsing();
            int count = 0;
            try
            {
                string scount = parsing.Parse_html(html);
                if (scount != "") { count = Convert.ToInt32(scount); } // если залито 9 и менее аккаунтов
                else { user_count = 10; return 0; } // если залито 10 и более
                
            }
            catch { return 0; } // Если неправильно парсит html

            if(user_count == 99) { user_count = count; return 0; } // Получили начальное количество
            if(user_count < count) { user_count = count; return 0; } // Если залил акки

            if (user_count > count) // Если начальное кол-во уменьшилось
            {
                count_akk = user_count - count; // Узнали сколько продал          

                using (StreamWriter sw = File.AppendText(path + @$"/users/{name}/{name}_log.txt"))
                {
                    if (user_count == 10) 
                    { sw.WriteLine(DateTime.Now.ToString("dd.MM.yyyy - HH:mm") + " - Продажа аккаунта " + count_akk + " штук" + " (возможно больше)" + " id " + Id); }

                    sw.WriteLine(DateTime.Now.ToString("dd.MM.yyyy - HH:mm") + " - Продажа аккаунта " + count_akk + " штук" + " id " + Id);
                   
                }
                SaveTotalSell(name, count_akk);

                user_count = count;
            }

            return count_akk;

        }
        private void SaveTotalSell(string name, int count)
        {
            int count_total = 0;

            using (StreamReader sr = new StreamReader(path + @$"/users/{name}/{name}_total.txt"))
            {
                count_total = Convert.ToInt32(sr.ReadLine());
                count_total += count;
            }

            using (StreamWriter sw = new StreamWriter(path + @$"/users/{name}/{name}_total.txt"))
            {
                sw.Write(count_total.ToString());
            }
        }
    }
}
