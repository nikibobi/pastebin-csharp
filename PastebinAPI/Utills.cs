using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace PastebinAPI
{
    class Utills
    {
        public static string PostRequest(string url, string[] parameters)
        {
            string postString = string.Join("&", parameters);
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes(postString);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            using (var dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            using (var response = request.GetResponse())
            {
                if (((HttpWebResponse)response).StatusDescription != "OK")
                {
                    Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                }
                using (var dataStream = response.GetResponseStream())
                {
                    if (dataStream != null)
                    {
                        using (var reader = new StreamReader(dataStream))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                    throw new NullReferenceException("dataStream from responce is null");
                }
            }
        }
    }
}
