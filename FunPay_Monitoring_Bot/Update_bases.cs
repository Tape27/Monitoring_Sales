using System.Reflection;

namespace FunPay_Monitoring_Bot
{
    internal class Update_bases
    {
        public static string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        public static void Update_day(string name, int count, int day)
        {
            using (StreamWriter sw = File.AppendText(path + @$"/users/{name}/{name}_day.txt"))
            {
                sw.WriteLine(day + "." + DateTime.Now.ToString("MM.yyyy") + " - " + count);
            }
        }
    }
}
