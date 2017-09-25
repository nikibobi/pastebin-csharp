using System;
using System.Collections.Generic;

namespace PastebinAPI
{
    public class PastebinException : Exception
    {
        public enum ParameterType
        {
            None,
            DevKey,
            ExpireDate,
            Option,
            PasteFormat,
            PastePrivate,
            UserKey,
            Login,
            DeletePastePermision,
            PostParameters
        }

        private static Dictionary<string, ParameterType> parameters = new Dictionary<string, ParameterType>
        {
            { "", ParameterType.None },
            { "api_dev_key", ParameterType.DevKey },
            { "api_expire_date", ParameterType.ExpireDate },
            { "api_option", ParameterType.Option },
            { "api_paste_format", ParameterType.PasteFormat },
            { "api_paste_private", ParameterType.PastePrivate },
            { "api_user_key", ParameterType.UserKey },
            { "login", ParameterType.Login },
            { "permission to remove paste", ParameterType.DeletePastePermision },
            { "POST parameters", ParameterType.PostParameters }
        };

        public ParameterType Parameter { get; private set; }

        public PastebinException(string message)
            : this(message, null)
        {
        }

        public PastebinException(string message, Exception innerException)
            : base(message, innerException)
        {
            if (message.Contains("Bad API request, invalid "))
            {
                Parameter = parameters[message.Replace("Bad API request, invalid ", "")];
            }
        }
    }
}
