using System.Collections.Generic;

namespace PastebinAPI
{
    public static class Pastebin
    {
        /// <summary>
        /// You must set this to your API dev key given by Pastebin before you use anything in the API
        /// </summary>
        public static string DevKey { get; set; }

        /// <summary>
        /// Log-in to Pastebin
        /// </summary>
        /// <returns>new User object</returns>
        public static User Login(string username, string password)
        {
            var result = Utills.PostRequest(Utills.URL_LOGIN,
                                            "api_dev_key=" + DevKey,
                                            "api_user_name=" + username,
                                            "api_user_password=" + password);

            if (result.Contains(Utills.ERROR))
                throw new PastebinException(result);

            return new User(result);
        }

        /// <summary>
        /// Lists the currently trending pastes
        /// </summary>
        /// <returns>Enumerable of the trending pastes</returns>
        public static IEnumerable<Paste> ListTrendingPastes()
        {
            var result = Utills.PostRequest(Utills.URL_API,
                                            "api_dev_key=" + DevKey,
                                            "api_option=" + "trends");

            if (result.Contains(Utills.ERROR))
                throw new PastebinException(result);

            return Utills.PastesFromXML(result);
        }
    }
}
