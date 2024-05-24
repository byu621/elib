namespace elib;

public class User : IUser
{
    public void ApplyBonusPoints(IMoney money)
    {
        Console.WriteLine($"I made an order of value {money}");
    }
}
