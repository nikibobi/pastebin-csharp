using System;
using System.Text;
using System.Xml.Linq;
using System.Collections.Generic;

namespace PastebinAPI
{
    public static class Pastebin
    {
        internal const string ERROR = "Bad API request";
        internal const string URL = @"http://pastebin.com/";
        internal const string URL_API = URL + @"api/api_post.php";
        internal const string URL_LOGIN = URL + @"api/api_login.php";

        public static string DevKey { get; set; }

        internal static Paste NewPaste(string userKey, string text, string title = "", PasteFormat format = null, Visibility visibility = Visibility.Public, Expiration expiration = null)
        {
            var result = Utills.PostRequest(URL_API,
                                            //required parameters
                                            "api_dev_key=" + DevKey,
                                            "api_option=" + "paste",
                                            "api_paste_code=" + Uri.EscapeDataString(text),
                                            //optional parameters
                                            "api_user_key=" + userKey,
                                            "api_paste_name=" + Uri.EscapeDataString(title),
                                            "api_paste_format=" + (format ?? PasteFormat.Default),
                                            "api_paste_private=" + (int)visibility,
                                            "api_paste_expire_date=" + (expiration ?? Expiration.Default));

            if (result.Contains(ERROR))
                throw new PastebinException(result);

            var paste = new Paste();
            paste.Key = result.Replace(URL, "");
            paste.Date = DateTime.Now;
            paste.Title = title;
            paste.Size = Encoding.Unicode.GetByteCount(text);
            paste.ExpireDate = paste.Date + expiration;
            paste.Expiration = expiration;
            paste.Visibility = visibility;
            paste.PasteFormat = format;
            paste.Hits = 0;
            paste.Url = result;
            paste.Text = text;

            return paste;
        }

        /// <summary>
        /// Creates new user
        /// </summary>
        /// <param name="username">The username</param>
        /// <param name="password">The password</param>
        /// <returns>User object</returns>
        public static User Login(string username, string password)
        {
            var result = Utills.PostRequest(URL_LOGIN,
                                            "api_dev_key=" + DevKey,
                                            "api_user_name=" + username,
                                            "api_user_password=" + password);

            if (result.Contains(ERROR))
                throw new PastebinException(result);

            return new User(DevKey, result);
        }

        /// <summary>
        /// Creates new paste and uploads it to pastebin
        /// </summary>
        /// <param name="text">The text/code of the paste</param>
        /// <param name="title">The title of the paste</param>
        /// <param name="format">The language for the paste see http://pastebin.com/api#5 for valid formats</param>
        /// <param name="visibility">The visibility/privacy of the paste</param>
        /// <param name="expiration">The expiration date of the paste</param>
        /// <returns>Responce from pastebin. If it succeeded it will return the paste url</returns>
        public static Paste NewPaste(string text, string title = "", PasteFormat format = null, Visibility visibility = Visibility.Public, Expiration expiration = null)
        {
            return NewPaste("", text, title, format, visibility, expiration);
        }

        /// <summary>
        /// Lists the currently trending pastes
        /// </summary>
        /// <returns>Enumerable of the trending pastes</returns>
        public static IEnumerable<Paste> ListTrendingPastes()
        {
            var result = Utills.PostRequest(URL_API,
                                            "api_dev_key=" + DevKey,
                                            "api_option=" + "trends");

            if (result.Contains(ERROR))
                throw new PastebinException(result);

            return Utills.PastesFromXML(result);
        }
    }
}
