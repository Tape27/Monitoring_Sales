
namespace FunPay_Monitoring_Bot
{
    internal class Parsing
    {
        public string Parse_html(string html)
        {
            string count = string.Empty;
            char[] arr = html.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'Н' && arr[i+1] == 'а' && arr[i+2] == 'л' && arr[i+3] == 'и' && arr[i+4] == 'ч' && arr[i+5] == 'и' && arr[i+6] == 'е') //35
                {
                    for (int y = i + 35; y < arr.Length; y++)
                    {
                        if (arr[y] == ' ') { break; }
                        count += arr[y];
                    }
                }
            }

            return count;
        }
        
    }
}
