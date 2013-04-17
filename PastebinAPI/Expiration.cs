namespace PastebinAPI
{
    public class Expiration
    {
        public static readonly Expiration Never = new Expiration("N");
        public static readonly Expiration TenMinutes = new Expiration("10M");
        public static readonly Expiration OneHour = new Expiration("1H");
        public static readonly Expiration OneDay = new Expiration("1D");
        public static readonly Expiration OneWeek = new Expiration("1W");
        public static readonly Expiration TwoWeeks = new Expiration("2W");
        public static readonly Expiration OneMonth = new Expiration("1M");
        public static readonly Expiration Default = Never;

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
