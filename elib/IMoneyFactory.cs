namespace elib;

public interface IMoneyFactory
{
    IMoney CreateMoney();
    IMoney CreateMoney(decimal value);
}
