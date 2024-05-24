// See https://aka.ms/new-console-template for more information
using elib;

IMoneyFactory moneyFactory = new MoneyFactory();
IFactory factory = new Factory();

IUser user = factory.CreateUser();
IOrder order = factory.CreateOrder(user, moneyFactory);

IProduct product = factory.CreateProduct("Obsidian", moneyFactory.CreateMoney(10.30m));
order.AddOrderLine(factory.CreateOrderLine(product, 2));

order.Process();