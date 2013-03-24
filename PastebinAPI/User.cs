using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PastebinAPI
{
    public class User
    {
        private readonly string userKey;
        private readonly string devKey;

        internal User(string devKey, string userKey)
        {
            this.devKey = devKey;
            this.userKey = userKey;
        }

        public Paste NewPaste(string text, string title = "", PasteFormat format = null, Visibility visibility = Visibility.Public, Expiration expiration = null)
        {
            return Pastebin.NewPaste(userKey, text, title, format, visibility, expiration);
        }

        public string ListPastes(int resultsLimit = 50)
        {
            var result = Utills.PostRequest(@"http://pastebin.com/api/api_post.php", new[]
                                                   {
                                                       "api_dev_key=" + devKey,
                                                       "api_user_key=" + userKey,
                                                       "api_results_limit=" + resultsLimit,
                                                       "api_option=" + "list"
                                                   });

            if (result.Contains(Pastebin.ERROR))
                throw new PastebinException(result);

            return result;
        }

        public void DeletePaste(Paste paste)
        {
            var result = Utills.PostRequest(@"http://pastebin.com/api/api_post.php", new[]
                                                   {
                                                       "api_dev_key=" + devKey,
                                                       "api_user_key=" + userKey,
                                                       "api_paste_key=" + paste.Key,
                                                       "api_option=" + "delete"
                                                   });

            if (result.Contains(Pastebin.ERROR))
                throw new PastebinException(result);
        }

        public string GetUserInfo()
        {
            var result = Utills.PostRequest(@"http://pastebin.com/api/api_post.php", new[]
                                                   {
                                                       "api_dev_key=" + devKey,
                                                       "api_user_key=" + userKey,
                                                       "api_option=" + "userdetails"
                                                   });

            if (result.Contains(Pastebin.ERROR))
                throw new PastebinException(result);

            return result;
        }
    }
}
