using System;
using System.Linq;
using System.Collections.Generic;

namespace PastebinAPI
{
    public class Expiration
    {
        public static readonly Expiration TenMinutes;
        public static readonly Expiration OneHour;
        public static readonly Expiration OneDay;
        public static readonly Expiration OneWeek;
        public static readonly Expiration TwoWeeks;
        public static readonly Expiration OneMonth;
        public static readonly Expiration Never;
        public static readonly Expiration Default;
        public static readonly IEnumerable<Expiration> All;

        static Expiration()
        {
            TenMinutes = new Expiration("10M", TimeSpan.FromMinutes(10));
            OneHour = new Expiration("1H", TimeSpan.FromHours(1));
            OneDay = new Expiration("1D", TimeSpan.FromDays(1));
            OneWeek = new Expiration("1W", TimeSpan.FromDays(7));
            TwoWeeks = new Expiration("2W", TimeSpan.FromDays(14));
            OneMonth = new Expiration("1M", TimeSpan.FromDays(30));
            Never = new Expiration("N", TimeSpan.MaxValue);
            Default = Never;
            All = getExpirations();
        }

        private static IEnumerable<Expiration> getExpirations()
        {
            yield return TenMinutes;
            yield return OneHour;
            yield return OneDay;
            yield return OneWeek;
            yield return TwoWeeks;
            yield return OneMonth;
            yield return Never;
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
            if (s == null)
                return false;
            foreach (Expiration expiration in All)
            {
                if (s.ToUpper() == expiration.value)
                {
                    result = expiration;
                    return true;
                }
            }
            return false;
        }

        public static Expiration FromTimeSpan(TimeSpan timeSpan)
        {
            //return All.First(e => timeSpan <= e.time); //maybe use this?
            foreach (Expiration expiration in All)
                if (timeSpan <= expiration.time)
                    return expiration;
            throw new InvalidOperationException(string.Format("Unreachable code reached! timeSpan = {0}", timeSpan));
        }

        private readonly string value;
        private readonly TimeSpan time;

        private Expiration(string value, TimeSpan time)
        {
            this.value = value;
            this.time = time;
        }

        public TimeSpan Time { get { return time; } }

        public override string ToString()
        {
            return value;
        }
    }
}
