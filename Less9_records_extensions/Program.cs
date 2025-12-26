namespace Less9_records_extensions;
using Less9_records_extensions.MyExt;
internal static class MyMath
{
    public static void Sum(int a, int b)
    {
        Console.WriteLine(a+b);
    }
}

//Extensions - методи розширення

internal class Program
{
    static void Change(int a)
    {
        a++;
    }
    static void Change(ref int[] arr)
    {
        arr = new int[arr.Length];
        arr[0] = 100;
    }
    static void Main(string[] args)
    {
        int n = 10;
        n.MyUp(23);
        Console.WriteLine(n);
        Student std = new Student("Bob", "Smith", "PV521");
        std.WelcomeStudent();

        //MyMath.Sum(3,4);
        //int[] arr = { 4, 5, 6 };
        //Change(ref arr);
        //foreach (int el in arr)
        //{
        //    Console.WriteLine(el);
        //}
    }
}
