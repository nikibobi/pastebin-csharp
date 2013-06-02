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
        internal static UserInfo FromXML(string s)
        {
            XElement user = XDocument.Parse(s).Element("user");
            UserInfo userInfo = new UserInfo()
            {
                Name = user.Element("user_name").Value,
                PasteFormat = PasteFormat.Parse(user.Element("user_format_short").Value),
                Expiration = Expiration.Parse(user.Element("user_expiration").Value),
                AvatarURL = user.Element("user_avatar_url").Value,
                Visibility = (Visibility)int.Parse(user.Element("user_private").Value),
                Website = user.Element("user_website").Value,
                Email = user.Element("user_email").Value,
                Location = user.Element("user_location").Value,
                IsPro = int.Parse(user.Element("user_account_type").Value) == 1,
            };
            return userInfo;
        }

        public string Name { get; private set; }
        public PasteFormat PasteFormat { get; private set; }
        public Expiration Expiration { get; private set; }
        public string AvatarURL { get; private set; }
        public Visibility Visibility { get; private set; }
        public string Website { get; private set; }
        public string Email { get; private set; }
        public string Location { get; private set; }
        public bool IsPro { get; private set; }

        public override string ToString()
        {
            //TODO: add a proper string format
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", Name, PasteFormat, Expiration, AvatarURL, Visibility, Website, Email, Location, IsPro);
        }
    }
}
