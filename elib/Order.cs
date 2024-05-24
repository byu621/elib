namespace elib;

public class Order : IOrder
{
    private readonly IUser user;
    private readonly IMoneyFactory moneyFactory;
    private IList<IOrderLine> orderLines;
    private readonly bool isProcessed;

    public Order(IUser user, IMoneyFactory moneyFactory)
    {
        this.user = user;
        this.moneyFactory = moneyFactory;
        orderLines = [];
        isProcessed = false;
    }

    public void Process()
    {
        if (isProcessed) throw new Exception();
        user.ApplyBonusPoints(GetOrderTotal());
    }

    public IMoney GetOrderTotal()
    {
        if (orderLines.Count == 0) return moneyFactory.CreateMoney();

        return orderLines
            .Select(ol => ol.GetMoney())
            .Aggregate((current, next) => current.Add(next));
    }

    public void AddOrderLine(IOrderLine orderLine)
    {
        orderLines.Add(orderLine);
    }
}

