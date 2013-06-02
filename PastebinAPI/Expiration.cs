using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PastebinAPI
{
    public class Expiration
    {
        public static Expiration Never { get { return Expirations["N"]; } }
        public static Expiration TenMinutes { get { return Expirations["10M"]; } }
        public static Expiration OneHour { get { return Expirations["1H"]; } }
        public static Expiration OneDay { get { return Expirations["1D"]; } }
        public static Expiration OneWeek { get { return Expirations["1W"]; } }
        public static Expiration TwoWeeks { get { return Expirations["2W"]; } }
        public static Expiration OneMonth { get { return Expirations["2W"]; } }
        public static Expiration Default { get { return Never; } }
        public static IEnumerable<Expiration> All { get { return Expirations.Values; } }

        internal static readonly Dictionary<string, Expiration> Expirations;

        static Expiration()
        {
            //lol wtf this is realy hacky xD
            Expirations = (new[] { "N", "10M", "1H", "1D", "1W", "2W", "1M" }).ToDictionary(s=>s, s=>new Expiration(s));
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
