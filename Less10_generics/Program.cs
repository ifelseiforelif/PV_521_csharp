using System.Collections;
using System.Collections.Generic;
namespace Less10_generics;


class Box<T>
{
    public T value;
    public Box(T content) 
    {
        this.value = content;
    }
    public T GetValue()
    {
        return value;
    }
    public void Print()
    {
        Console.WriteLine(value);
    }
}

internal class Program
{
    /*
     * Створити generic клас Pair<T1, T2> 
     * для зберігання двох значень різного типу.
Додати метод Display(), який виводить обидва значення.
    Pair<string, int> p1 = new Pair<string, int>();
    p1.Add("bread", 30);
    p1.Display();
     */
    static void Main(string[] args)
    {
        List<string> names = new List<string>();
        names.Add("Bob");
        names.Add("Alice");
        names.Add("John");
        Stack<string> stack = new Stack<string>();
        LinkedList<string> list = new LinkedList<string>();

        Box<int> box1 = new Box<int>(10);
        Console.WriteLine(box1.GetValue());
        Box<string> box2 = new Box<string>("Hi");
        Console.WriteLine(box2.GetValue());

        //Hashtable ht = new Hashtable();
        //ht["Alice"] = 20;

        //ArrayList list = new ArrayList();
        //list.Add(10);
        //list.Add(true);
        //list.Add("Hi");
        //Console.WriteLine(list[2]);
        //Console.WriteLine((int)list[0]*2);

        //Box box1 = new Box(1); //int
        //Box box2 = new Box(4.5); //double
        //Box box3 = new Box("Hello"); //string
        //Box box4 = new Box(box1); //string

        //int x = (int)box1.value;
        //Console.WriteLine(x);

    }
}
