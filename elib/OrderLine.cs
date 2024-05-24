namespace elib;

public class OrderLine : IOrderLine
{
    private IProduct product;
    private int quantity;

    public OrderLine(IProduct product, int quantity)
    {
        this.product = product;
        this.quantity = quantity;
    }

    public IMoney GetMoney()
    {
        return product.GetMoney() * quantity;
    }
}
