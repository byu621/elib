namespace elib;

public interface IFactory
{
    IOrder CreateOrder(IUser user, IMoneyFactory moneyFactory);
    IOrderLine CreateOrderLine(IProduct product, int quantity);
    IProduct CreateProduct(string name, IMoney price);
    IUser CreateUser();
}
