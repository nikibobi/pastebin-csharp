using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PastebinAPI
{
    public class Expiration
    {
        public const string DFAULT = "N";

        public static readonly Expiration Never = new Expiration("N");
        public static readonly Expiration TenMinutes = new Expiration("10M");
        public static readonly Expiration OneHour = new Expiration("1H");
        public static readonly Expiration OneDay = new Expiration("1D");
        public static readonly Expiration OneMonth = new Expiration("1M");

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
