using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace PastebinAPI
{
    public struct PasteInfo
    {
        /*
        by user
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
        
        trending
        <paste>
	        <paste_key>4eWYATXe</paste_key>
	        <paste_date>1319458935</paste_date>
	        <paste_title>577 French MPs</paste_title>
	        <paste_size>29397</paste_size>
	        <paste_expire_date>0</paste_expire_date>
	        <paste_private>0</paste_private>
	        <paste_format_long>None</paste_format_long>
	        <paste_format_short>text</paste_format_short>
	        <paste_url>http://pastebin.com/4eWYATXe</paste_url>
	        <paste_hits>804</paste_hits>
        </paste>
        
        my paste
        <paste>
            <paste_key>gUVtijqB</paste_key>
            <paste_date>1364152991</paste_date>
            <paste_title>earnet</paste_title>
            <paste_size>1815</paste_size>
            <paste_expire_date>0</paste_expire_date>
            <paste_private>0</paste_private>
            <paste_format_long>Lua</paste_format_long>
            <paste_format_short>lua</paste_format_short>
            <paste_url>http://pastebin.com/gUVtijqB</paste_url>
            <paste_hits>36</paste_hits>
        </paste>
<paste>
<paste_key>8G5bzdPp</paste_key>
<paste_date>1370204729</paste_date>
<paste_title>Test paste</paste_title>
<paste_size>58</paste_size>
<paste_expire_date>1370291129</paste_expire_date>
<paste_private>0</paste_private>
<paste_format_long>C</paste_format_long>
<paste_format_short>c</paste_format_short>
<paste_url>http://pastebin.com/8G5bzdPp</paste_url>
<paste_hits>3</paste_hits>
</paste>
         */

        internal static PasteInfo FromXML(XElement paste)
        {
            return new PasteInfo()
            {
                Key = paste.Element("paste_key").Value,
                Date = Utills.GetDate(long.Parse(paste.Element("paste_date").Value)),
                Title = paste.Element("paste_title").Value,
                Size = int.Parse(paste.Element("paste_size").Value),
                ExpireDate = Utills.GetDate(long.Parse(paste.Element("paste_expire_date").Value)),
                Visibility = (Visibility)int.Parse(paste.Element("paste_private").Value),
                PasteFormat = PasteFormat.Parse(paste.Element("paste_format_short").Value),
                Url = paste.Element("paste_url").Value,
                Hits = int.Parse(paste.Element("paste_hits").Value),
            };
        }

        //TODO: figure out how Date and ExpireDate are stored in XML

        public string Key { get; private set; }
        public DateTime Date { get; private set; }
        public string Title { get; private set; }
        public int Size { get; private set; } ///<summary>File size in bytes</summary>
        public DateTime ExpireDate { get; private set; }
        public Visibility Visibility { get; private set; }
        public PasteFormat PasteFormat { get; private set; }
        public string Url { get; private set; }
        public int Hits { get; private set; }
    }
}
