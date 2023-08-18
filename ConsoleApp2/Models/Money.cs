namespace ConsoleApp2.Models
{
    public class Money
    {
        public decimal Value { get; set; }

        public Money()
        {
        }

        public Money(decimal value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            Money money = obj as Money;
            if (money == null)
            {
                return false;
            }

            if (this == money)
            {
                return true;
            }

            return Value.Equals(money.Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}