namespace Bridge.Entity
{
    public class Address
    {
        public enum countryOptions { Ukraine, Belarus, Russia };
        public enum cityOptions { Kyiv, Mariupol, Lviv, Moscov, SaintPetersburg, RostovOnDon, Minsk, Mogilev, Gomel };
        public enum stritsOptions { KhreschatykSt, MyruAve, SvobodyAve, TverskayaSt, NevskyAve, BudonnovskiyAve, vulycaLienina, PiershamajskayaSt, BarykinSt };

        public countryOptions Country { get; set; }
        public cityOptions City { get; set; }
        public stritsOptions Street { get; set; }
        public Money Price { get; set; }
    }
}