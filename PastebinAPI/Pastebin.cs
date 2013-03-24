using System;
using System.Collections.Generic;

namespace PastebinAPI
{
    public static class Pastebin
    {
        internal const string ERROR = "Bad API request";

        private static bool initialized;
        private static string devkey;

        public static string DevKey
        {
            get
            {
                return devkey;
            }
            set
            {
                devkey = value;
                initialized = true;
            }
        }

        public static User Login(string username, string password)
        {
            var result = Utills.PostRequest(@"http://pastebin.com/api/api_login.php", new[]
                                                   {
                                                       "api_dev_key=" + DevKey,
                                                       "api_user_name=" + username,
                                                       "api_user_password=" + password
                                                   });

            if (result.Contains(ERROR))
                throw new PastebinException(result);

            return new User(DevKey, result);
        }

        /// <summary>
        /// Creates new paste and uploads it to pastebin
        /// </summary>
        /// <param name="text">The text/code of the paste</param>
        /// <param name="title">The title of the paste</param>
        /// <param name="language">The language for the paste see http://pastebin.com/api#5 for valid formats</param>
        /// <param name="visibility">The visibility/privacy of the paste</param>
        /// <param name="expiration">The expiration date of the paste</param>
        /// <param name="userKey">The userKey </param>
        /// <returns>Responce from pastebin. If it succeeded it will return the paste url</returns>
        public static Paste NewPaste(string text, string title = "", string language = "text", Visibility visibility = 0, Expiration expiration = null, string userKey = "")
        {
            var result = Utills.PostRequest(@"http://pastebin.com/api/api_post.php", new[]
                                                   {
                                                       //required parameters
                                                       "api_dev_key=" + DevKey,
                                                       "api_option=" + "paste",
                                                       "api_paste_code=" + Uri.EscapeDataString(text),
                                                       //optional parameters
                                                       "api_user_key=" + userKey,
                                                       "api_paste_name=" + Uri.EscapeDataString(title),
                                                       "api_paste_format=" + language,
                                                       "api_paste_private=" + (int) visibility,
                                                       "api_paste_expire_date=" + expiration
                                                   });

            if (result.Contains(ERROR))
                throw new PastebinException(result);

            return new Paste(result);
        }

        public static string ListTrendingPastes()
        {
            var result = Utills.PostRequest(@"http://pastebin.com/api/api_post.php", new[]
                                                   {
                                                       "api_dev_key=" + DevKey,
                                                       "api_option=" + "trends"
                                                   });

            if (result.Contains(ERROR))
                throw new PastebinException(result);

            return result;
        }
    }
}
