using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PastebinAPI
{
    public struct Paste
    {
        private string url;
        private string key;

        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
                key = url.Replace("http://pastebin.com/", "");
            }
        }
        public string Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
                url = "http://pastebin.com/" + key;
            }
        }

        public Paste(string url) : this()
        {
            Url = url;
        }

        public string GetRaw()
        {
            return Utills.PostRequest("http://pastebin.com/raw.php?i=" + Key, new[]{""});
        }
    }
}
