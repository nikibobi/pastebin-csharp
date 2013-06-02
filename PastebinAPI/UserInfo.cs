using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Text;

namespace PastebinAPI
{
    public struct UserInfo
    {
        /* Example xml
        <user>
	        <user_name>wiz_kitty</user_name>
	        <user_format_short>text</user_format_short>
	        <user_expiration>N</user_expiration>
	        <user_avatar_url>http://pastebin.com/cache/a/1.jpg</user_avatar_url>
	        <user_private>1</user_private> (0 Public, 1 Unlisted, 2 Private)
	        <user_website>http://myawesomesite.com</user_website>
	        <user_email>oh@dear.com</user_email>
	        <user_location>New York</user_location>
	        <user_account_type>1</user_account_type> (0 normal, 1 PRO)
        </user>
         */
        internal static UserInfo Parse(string s)
        {
            XDocument xml = XDocument.Parse(s);
            UserInfo userInfo = new UserInfo()
            {
                Name = xml.Element("user_name").Value,
                FormatShort = xml.Element("user_format_short").Value,
                Expiration = Expiration.Expirations[xml.Element("user_expiration").Value],
                AvatarURL = xml.Element("user_avatar_url").Value,
                Visibility = (Visibility)int.Parse(xml.Element("user_private").Value),
                Website = xml.Element("user_website").Value,
                Email = xml.Element("user_email").Value,
                Location = xml.Element("user_location").Value,
                IsPro = int.Parse(xml.Element("user_account_type").Value) == 1,
            };
            return userInfo;
        }

        public string Name { get; private set; }
        public string FormatShort { get; private set; }
        public Expiration Expiration { get; private set; }
        public string AvatarURL { get; private set; }
        public Visibility Visibility { get; private set; }
        public string Website { get; private set; }
        public string Email { get; private set; }
        public string Location { get; private set; }
        public bool IsPro { get; private set; }
    }
}
