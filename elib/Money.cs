namespace elib;

public class Money : IMoney
{
    private int cents;

    public Money(int cents)
    {
        this.cents = cents;
    }

    public Money(decimal value)
    {
        int cents =  (int)Math.Round(value * 100);
        this.cents = cents;
    }

    public IMoney Add(IMoney other)
    {
        decimal value = GetValue() + other.GetValue();
        int cents =  (int)Math.Round(value * 100);
        return new Money(cents);
    }

    public decimal GetValue()
    {
        return (decimal)cents/100;
    }

    public IMoney Multiply(IMoney other)
    {
        decimal value = GetValue() * other.GetValue();
        int cents = (int)Math.Round(value * 100);
        return new Money(cents);
    }

    public IMoney Multiply(int other)
    {
        decimal value = GetValue() * other;
        int cents = (int)Math.Round(value * 100);
        return new Money(cents);
    }

    public override string ToString()
    {
        return $"${GetValue()}0";
    }
}
