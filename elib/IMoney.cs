namespace elib;

public interface IMoney
{
    decimal GetValue();
    IMoney Add(IMoney other);
    IMoney Multiply(IMoney other);
    IMoney Multiply(int other);
    public static IMoney operator+ (IMoney a, IMoney b)
    {
        return a.Add(b);
    }
    public static IMoney operator* (IMoney a, IMoney b)
    {
        return a.Multiply(b);
    }
    public static IMoney operator* (IMoney a, int b)
    {
        return a.Multiply(b);
    }
}
