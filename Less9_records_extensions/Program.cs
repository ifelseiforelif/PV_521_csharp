namespace Less9_records_extensions;
using Less9_records_extensions.MyExt;
using System.Runtime.InteropServices;

internal static class MyMath
{
    public static void Sum(int a, int b)
    {
        Console.WriteLine(a+b);
    }
}

//Extensions - методи розширення
//records

//C#9, C#10
public record Animal();
public record Cat(string Name, string Color, short Age)
{
    public string Name { get; set; }
    public readonly string Color { get; init; }
}
public record struct Dog(string Name, string Color, short Age)
{

}

//get; init

internal class Program
{
    
    static void Main(string[] args)
    {

        Dog dog1 = new Dog("Jack", "Black", 3);
        dog1.Age ++;
        Console.WriteLine(dog1);
        Cat cat = new Cat("Grey", "white", 2);
        cat = cat with
        {
            Age = 3,
            Color = "Brown"
        };

        Cat cat2 = new Cat("Grey", "white", 2);
        if(cat==cat2)
        {
            Console.WriteLine("Equals");
        }
        if(ReferenceEquals(cat, cat2))
        {
            Console.WriteLine("Equals");
        }
        //cat.Name = "White"; //IMMUTABLE
        Console.WriteLine(cat);
        Student std1 = new Student("Bob", "Smith", "PV521");
        Student std2 = new Student("Bob", "Smith", "PV521");
        if(std1==std2)
        {
            Console.WriteLine("Equals");
        }

        //int n = 10;
        //n.MyUp(23);
        //Console.WriteLine(n);
        //Student std = new Student("Bob", "Smith", "PV521");
        //std.WelcomeStudent();

        //MyMath.Sum(3,4);
        //int[] arr = { 4, 5, 6 };
        //Change(ref arr);
        //foreach (int el in arr)
        //{
        //    Console.WriteLine(el);
        //}
    }
    static void Change(int a)
    {
        a++;
    }
    static void Change(ref int[] arr)
    {
        arr = new int[arr.Length];
        arr[0] = 100;
    }
}
