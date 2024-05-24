namespace elib;

public class Factory : IFactory
{
    public IOrder CreateOrder(IUser user, IMoneyFactory moneyFactory)
    {
        return new Order(user, moneyFactory);
    }

    public IOrderLine CreateOrderLine(IProduct product, int quantity)
    {
        return new OrderLine(product, quantity);
    }

    public IProduct CreateProduct(string name, IMoney price)
    {
        return new Product(name, price);
    }

    public IUser CreateUser()
    {
        return new User();
    }
}
