using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;

namespace PastebinAPI
{
    public class Pastebin
    {
        public class Expiration
        {
            public const string DFAULT = "N";

            public static readonly Expiration Never = new Expiration("N");
            public static readonly Expiration TenMinutes = new Expiration("10M");
            public static readonly Expiration OneHour = new Expiration("1H");
            public static readonly Expiration OneDay = new Expiration("1D");
            public static readonly Expiration OneMonth = new Expiration("1M");

            private readonly string value;
            private Expiration(string value)
            {
                this.value = value;
            }
            public override string ToString()
            {
                return value;
            }
        }

        public enum Visibility
        {
            Public = 0,
            Unlisted = 1,
            Private = 2
        }

        #region Errors

        private static readonly Dictionary<string, List<string>> errors = new Dictionary<string, List<string>>
        {
            {
                "paste", new List<string>
                            {
                                "Bad API request, invalid api_option",
                                "Bad API request, invalid api_dev_key",
                                "Bad API request, IP blocked",
                                "Bad API request, maximum number of 25 unlisted pastes for your free account",
                                "Bad API request, maximum number of 10 private pastes for your free account",
                                "Bad API request, api_paste_code was empty",
                                "Bad API request, maximum paste file size exceeded",
                                "Bad API request, invalid api_expire_date",
                                "Bad API request, invalid api_paste_private",
                                "Bad API request, invalid api_paste_format"
                            }
                },
            {
                "login", new List<string>
                            {
                                "Bad API request, use POST request, not GET",
                                "Bad API request, invalid api_dev_key",
                                "Bad API request, invalid login",
                                "Bad API request, account not active",
                                "Bad API request, invalid POST parameters"
                            }
                },
            {
                "list", new List<string>
                            {
                                "Bad API request, invalid api_option",
                                "Bad API request, invalid api_dev_key",
                                "Bad API request, invalid api_user_key"
                            }
                },
            {
                "trends", new List<string>
                            {
                                "Bad API request, invalid api_option",
                                "Bad API request, invalid api_dev_key"
                            }
                },
            {
                "delete", new List<string>
                            {
                                "Bad API request, invalid api_option",
                                "Bad API request, invalid api_dev_key",
                                "Bad API request, invalid api_user_key",
                                "Bad API request, invalid permission to remove paste"
                            }
                },
            {
                "userdetails", new List<string>
                            {
                                "Bad API request, invalid api_option",
                                "Bad API request, invalid api_dev_key",
                                "Bad API request, invalid api_user_key"
                            }
                }
        };
        #endregion

        private readonly string devKey;
        private string userKey;

        /// <summary>
        /// Creates new Pastebin object
        /// </summary>
        /// <param name="devKey">Your api dev key</param>
        public Pastebin(string devKey)
        {
            this.devKey = devKey;
            userKey = string.Empty;
        }

        public void Login(string username, string password)
        {
            var postData = string.Join("&", new[]
                                                   {
                                                       "api_dev_key=" + devKey,
                                                       "api_user_name=" + username,
                                                       "api_user_password=" + password
                                                   });

            var result = PostRequest(@"http://pastebin.com/api/api_login.php", postData);

            if (errors["login"].Contains(result))
                throw new ArgumentException("Pastebin API error: " + result);

            userKey = result;
        }

        public void Logout()
        {
            if (userKey == string.Empty)
                throw new InvalidOperationException("Must first login to logout");
            userKey = "";
        }

        /// <summary>
        /// Creates new paste and uploads it to pastebin
        /// </summary>
        /// <param name="text">The text/code of the paste</param>
        /// <param name="title">The title of the paste</param>
        /// <param name="language">The language for the paste see http://pastebin.com/api#5 for valid formats</param>
        /// <param name="visibility">The visibility/privacy of the paste</param>
        /// <param name="expiration">The expiration date of the paste</param>
        /// <returns>Responce from pastebin. If it succeeded it will return the paste url</returns>
        public string Create(string text, string title = "", string language = "text", Visibility visibility = 0, Expiration expiration = null)
        {
            var postData = string.Join("&", new[]
                                                   {
                                                       //required parameters
                                                       "api_dev_key=" + devKey,
                                                       "api_option=" + "paste",
                                                       "api_paste_code=" + Uri.EscapeDataString(text),
                                                       //optional parameters
                                                       "api_user_key=" + userKey,
                                                       "api_paste_name=" + Uri.EscapeDataString(title),
                                                       "api_paste_format=" + language,
                                                       "api_paste_private=" + (int) visibility,
                                                       "api_paste_expire_date=" + expiration
                                                   });
            var result = PostRequest(@"http://pastebin.com/api/api_post.php", postData);

            if (errors["paste"].Contains(result))
                throw new ArgumentException("Pastebin API error: " + result);

            return result;
        }

        public string ListPastesByUser(int resultsLimit = 50)
        {
            var postData = string.Join("&", new[]
                                                   {
                                                       "api_dev_key=" + devKey,
                                                       "api_user_key=" + userKey,
                                                       "api_results_limit=" + resultsLimit,
                                                       "api_option=" + "list"
                                                   });

            var result = PostRequest(@"http://pastebin.com/api/api_post.php", postData);

            if (errors["list"].Contains(result))
                throw new ArgumentException("Pastebin API error: " + result);

            return result;
        }

        public string ListTrendingPastes()
        {
            var postData = string.Join("&", new[]
                                                   {
                                                       "api_dev_key=" + devKey,
                                                       "api_option=" + "trends"
                                                   });

            var result = PostRequest(@"http://pastebin.com/api/api_post.php", postData);

            if (errors["trends"].Contains(result))
                throw new ArgumentException("Pastebin API error: " + result);

            return result;
        }

        public void DeletePasteByUser(string pasteKey)
        {
            var postData = string.Join("&", new[]
                                                   {
                                                       "api_dev_key=" + devKey,
                                                       "api_user_key=" + userKey,
                                                       "api_paste_key=" + pasteKey,
                                                       "api_option=" + "delete"
                                                   });

            var result = PostRequest(@"http://pastebin.com/api/api_post.php", postData);

            if (errors["delete"].Contains(result) || result != "Paste Removed")
                throw new ArgumentException("Pastebin API error: " + result);
        }

        public string GetUserInfo()
        {
            var postData = string.Join("&", new[]
                                                   {
                                                       "api_dev_key=" + devKey,
                                                       "api_user_key=" + userKey,
                                                       "api_option=" + "userdetails"
                                                   });

            var result = PostRequest(@"http://pastebin.com/api/api_post.php", postData);

            if (errors["userdetails"].Contains(result))
                throw new ArgumentException("Pastebin API error: " + result);

            return result;
        }

        public string GetRaw(string pasteKey)
        {
            var url = "http://pastebin.com/raw.php?i=" + pasteKey;
            return PostRequest(url, "");
        }

        public static string UrlToPasteKey(string url)
        {
            return url.Replace("http://pastebin.com/", "");
        }

        public static string PasteKeyToUrl(string pasteKey)
        {
            return "http://pastebin.com/" + pasteKey;
        }

        private static string PostRequest(string url, string postString)
        {
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
