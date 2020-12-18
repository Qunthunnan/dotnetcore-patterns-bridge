namespace Bridge.Entity
{
    public class Money
    {
        public enum CurrencyType
        {
            RUB
            ,EUR
            ,USD
            ,GRN
            ,BYN
        }
        public double Value { get; set; }
        public CurrencyType Currency{ get; set; }
        public void Add(Money newValue)
        {
            Value += newValue.Value;
        }
    }
}