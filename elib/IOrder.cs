namespace elib;

public interface IOrder
{
    void Process();
    IMoney GetOrderTotal();
    void AddOrderLine(IOrderLine orderLine);
}
