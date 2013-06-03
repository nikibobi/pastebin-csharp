using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace PastebinAPI
{
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
	            <paste_url>http://pastebin.com/0b42rwhf</paste_url>
	            <paste_hits>15</paste_hits>
            </paste>
             */
            var paste = new Paste();
            paste.Key = xpaste.Element("paste_key").Value;
            paste.Date = Utills.GetDate(long.Parse(xpaste.Element("paste_date").Value));
            paste.Title = xpaste.Element("paste_title").Value;
            paste.Size = int.Parse(xpaste.Element("paste_size").Value);
            var expTicks = long.Parse(xpaste.Element("paste_expire_date").Value);
            if (expTicks != 0)
            {
                paste.ExpireDate = Utills.GetDate(expTicks);
                paste.Expiration = paste.ExpireDate - paste.Date;
            }
            else
            {
                paste.ExpireDate = DateTime.MaxValue;
                paste.Expiration = Expiration.Never;
            }
            paste.Visibility = (Visibility)int.Parse(xpaste.Element("paste_private").Value);
            paste.PasteFormat = PasteFormat.Parse(xpaste.Element("paste_format_short").Value);
            paste.Url = xpaste.Element("paste_url").Value;
            paste.Hits = int.Parse(xpaste.Element("paste_hits").Value);
            return paste;
        }

        public string Key { get; internal set; }
        public DateTime Date { get; internal set; }
        public string Title { get; internal set; }
        public int Size { get; internal set; } ///<summary>File size in bytes</summary>
        public DateTime ExpireDate { get; internal set; }
        public Expiration Expiration { get; internal set; }
        public Visibility Visibility { get; internal set; }
        public PasteFormat PasteFormat { get; internal set; }
        public string Url { get; internal set; }
        public int Hits { get; internal set; }
        public string Text { get; internal set; }

        internal Paste() { }

        public string GetRaw()
        {
            return Text = Utills.PostRequest("http://pastebin.com/raw.php?i=" + Key);
        }

        public override string ToString()
        {
            return Text ?? GetRaw();
        }
    }
}
