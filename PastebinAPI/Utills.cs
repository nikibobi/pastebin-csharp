using System.IO;
using System.Net;
using System.Text;

namespace PastebinAPI
{
    class Utills
    {
        public static string PostRequest(string url, string[] parameters)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            string postString = string.Join("&", parameters);
            byte[] byteArray = Encoding.UTF8.GetBytes(postString);
            request.ContentLength = byteArray.Length;
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            using (WebResponse response = request.GetResponse())
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
