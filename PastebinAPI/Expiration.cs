using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PastebinAPI
{
    public class Expiration
    {
        #region Expirations
        public static Expiration Never { get { return Expirations["N"]; } }
        public static Expiration TenMinutes { get { return Expirations["10M"]; } }
        public static Expiration OneHour { get { return Expirations["1H"]; } }
        public static Expiration OneDay { get { return Expirations["1D"]; } }
        public static Expiration OneWeek { get { return Expirations["1W"]; } }
        public static Expiration TwoWeeks { get { return Expirations["2W"]; } }
        public static Expiration OneMonth { get { return Expirations["2W"]; } }
        #endregion
        public static Expiration Default { get { return Never; } }
        public static IEnumerable<Expiration> All { get { return Expirations.Values; } }

        private static readonly Dictionary<string, Expiration> Expirations;
        static Expiration()
        {
            //lol wtf this is realy hacky xD
            Expirations = (new[] { "N",
                                   "10M",
                                   "1H",
                                   "1D",
                                   "1W",
                                   "2W",
                                   "1M" }).ToDictionary(s=>s, s=>new Expiration(s));
        }

        public static Expiration Parse(string s)
        {
            Expiration result;
            if (s == null)
                throw new ArgumentNullException("s");
            if(TryParse(s, out result) == false)
                throw new FormatException(string.Format("Format: {0} is not supported", s));
            return result;
        }

        public static bool TryParse(string s, out Expiration result)
        {
            result = Default;
            if (s == null || Expirations.ContainsKey(s) == false)
                return false;
            result = Expirations[s];
            return true;
        }

        private readonly string value;
        private Expiration(string value)
        {
            this.value = value;
        }
        public override string ToString()
        {
            return value;
        }
    }
}
