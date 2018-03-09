using System;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace PastebinAPI
{
    using static Utills;

    public class Paste
    {
        internal static Paste FromXML(XElement xpaste)
        {
            /* Example paste xml
            <paste>
	            <paste_key>0b42rwhf</paste_key>
	            <paste_date>1297953260</paste_date>
	            <paste_title>javascript test</paste_title>
	            <paste_size>15</paste_size>
	            <paste_expire_date>1297956860</paste_expire_date>
	            <paste_private>0</paste_private>
	            <paste_format_long>JavaScript</paste_format_long>
	            <paste_format_short>javascript</paste_format_short>
	            <paste_url>https://pastebin.com/0b42rwhf</paste_url>
	            <paste_hits>15</paste_hits>
            </paste>
             */
            var paste = new Paste();
            paste.Key = xpaste.Element("paste_key").Value;
            paste.CreateDate = GetDate((long)xpaste.Element("paste_date"));
            paste.Title = xpaste.Element("paste_title").Value;
            paste.Size = (int)xpaste.Element("paste_size");
            var exdate = (long)xpaste.Element("paste_expire_date");
            paste.ExpireDate = exdate != 0 ? GetDate(exdate) : paste.CreateDate;
            paste.Expiration = Expiration.FromTimeSpan(paste.ExpireDate - paste.CreateDate);
            paste.Visibility = (Visibility)(int)xpaste.Element("paste_private");
            paste.Language = Language.Parse(xpaste.Element("paste_format_short").Value);
            paste.Url = xpaste.Element("paste_url").Value;
            paste.Hits = (int)xpaste.Element("paste_hits");
            return paste;
        }

        internal static async Task<Paste> CreateAsync(string userKey, string text, string title = null, Language language = null, Visibility visibility = Visibility.Public, Expiration expiration = null)
        {
            title = title ?? "Untitled";
            language = language ?? Language.Default;
            expiration = expiration ?? Expiration.Default;

            var result = await PostRequestAsync(URL_API,
                                            //required parameters
                                            "api_dev_key=" + Pastebin.DevKey,
                                            "api_option=" + "paste",
                                            "api_paste_code=" + Uri.EscapeDataString(text),
                                            //optional parameters
                                            "api_user_key=" + userKey,
                                            "api_paste_name=" + Uri.EscapeDataString(title),
                                            "api_paste_format=" + language,
                                            "api_paste_private=" + (int)visibility,
                                            "api_paste_expire_date=" + expiration);

            if (result.Contains(ERROR))
                throw new PastebinException(result);

            var paste = new Paste();
            paste.Key = result.Replace(URL, string.Empty);
            paste.CreateDate = DateTime.Now;
            paste.Title = title;
            paste.Size = Encoding.UTF8.GetByteCount(text);
            paste.ExpireDate = paste.CreateDate + expiration.Time;
            paste.Expiration = expiration;
            paste.Visibility = visibility;
            paste.Language = language;
            paste.Hits = 0;
            paste.Url = result;
            paste.Text = text;

            return paste;
        }

        /// <summary>
        /// Creates a new paste anonymously and uploads it to pastebin
        /// </summary>
        /// <returns>Paste object containing the Url given from Pastebin</returns>
        public static async Task<Paste> CreateAsync(string text, string title = null, Language language = null, Visibility visibility = Visibility.Public, Expiration expiration = null)
        {
            return await CreateAsync("", text, title, language, visibility, expiration);
        }

        ///<summary>String of 8 characters that is appended at the end of the url</summary>
        public string Key { get; private set; }
        ///<summary>Date at witch the paste was created</summary>
        public DateTime CreateDate { get; private set; }
        public string Title { get; private set; }
        ///<summary>File size in bytes</summary>
        public int Size { get; private set; }
        ///<summary>Date at witch the paste will be removed from Pastebin</summary>
        public DateTime ExpireDate { get; private set; }
        public Expiration Expiration { get; private set; }
        public Visibility Visibility { get; private set; }
        public Language Language { get; private set; }
        public string Url { get; private set; }
        ///<summary>Number of views</summary>
        public int Hits { get; private set; }
        public string Text { get; private set; }

        private Paste() { }

        /// <summary>
        /// Gets the raw text for a given url
        /// </summary>
        public async Task<string> GetRawAsync()
        {
            if (Visibility == Visibility.Private)
                throw new PastebinException("Private pastes can not be accessed");
            return Text = await PostRequestAsync(URL_RAW + Key);
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
