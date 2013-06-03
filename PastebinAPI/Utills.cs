using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Linq;
using System.Collections.Generic;

namespace PastebinAPI
{
    class Utills
    {
        public static IEnumerable<Paste> PastesFromXML(string xml)
        {
            foreach (var paste in XDocument.Parse("<pastes>" + xml + "</pastes>").Descendants("paste"))
                yield return Paste.FromXML(paste);
        }

        public static DateTime GetDate(long ticks)
        {
            //TODO: Make this accurate
            return (new DateTime(1970, 1, 1).ToUniversalTime() - TimeSpan.FromHours(3) + TimeSpan.FromSeconds(ticks));
        }

        public static string PostRequest(string url, params string[] parameters)
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
