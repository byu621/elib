namespace elib;

public class Product : IProduct
{
    private string name;
    private IMoney price;
    private int version;

    public Product(string name, IMoney price) : this(name, price, 0) {}

    public Product(string name, IMoney price, int version)
    {
        this.name = name;
        this.price = price;
        this.version = version;
    }

    public IMoney GetMoney()
    {
        return price;
    }
}
