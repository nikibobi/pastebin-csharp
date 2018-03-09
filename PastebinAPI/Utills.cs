using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PastebinAPI
{
    class Utills
    {
        public const string ERROR = @"Bad API request";
        public const string URL = @"https://pastebin.com/";
        public const string URL_API = URL + @"api/api_post.php";
        public const string URL_LOGIN = URL + @"api/api_login.php";
        public const string URL_RAW = URL + @"raw.php?i=";

        private static readonly HttpClient http = new HttpClient();

        public static IEnumerable<Paste> PastesFromXML(string xml)
        {
            foreach (var paste in XElement.Parse("<pastes>" + xml + "</pastes>").Descendants("paste"))
                yield return Paste.FromXML(paste);
        }

        public static DateTime GetDate(long ticks)
        {
            return new DateTime(1970, 1, 1).AddSeconds(ticks).ToLocalTime();
        }

        public static async Task<string> PostRequestAsync(string url, params string[] parameters)
        {
            try
            {
                string postString = string.Join("&", parameters);
                byte[] byteArray = Encoding.UTF8.GetBytes(postString);
                var content = new ByteArrayContent(byteArray);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                var response = await http.PostAsync(url, content);
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                throw new PastebinException("Connection to Pastebin failed", ex);
            }
        }
    }
}
