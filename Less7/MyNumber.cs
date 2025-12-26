using System.Runtime.CompilerServices;

namespace Less7;

public class MyNumber
{
    public int Value { get; set; }
    public MyNumber()
    {
        Value = 0;
    }
    public MyNumber(int value)
    {
        Value = value;
    }
    public static MyNumber operator++(MyNumber obj)
    {
        obj.Value++;
        return obj;
    }
    public static MyNumber operator --(MyNumber obj)
    {
        obj.Value--;
        return obj;
    }
    public override string ToString()
    {
        return $"Value: {Value}";
    }
}
