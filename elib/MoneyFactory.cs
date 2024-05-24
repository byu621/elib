namespace elib;

public class MoneyFactory : IMoneyFactory
{
    public IMoney CreateMoney()
    {
        return new Money(0);
    }

    public IMoney CreateMoney(decimal value)
    {
        return new Money(value);
    }
}
