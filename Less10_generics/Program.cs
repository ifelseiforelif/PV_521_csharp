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

class Shape
{
    public virtual void Draw() { }
}
class Rect : Shape {
    public void Draw()
    {
        Console.WriteLine("Rect");
    }
}
class Circle : Shape
{
    public void Draw(int n) { }
}

class Canvas
{
    public void Paint(Shape shape)
    {
        shape.Draw();
    }
}

internal class Program
{
    static void Print(IEnumerable<int> my_list)
    {
        foreach(var el in my_list)
        {
            Console.Write($"{el} ");
        }
        Console.WriteLine();
    }




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
        //    int[] arr = new int[3] { 8, 9, 0 };
        //    Array.Sort(arr);
        //    Print(arr);
        //    List<int> list = new List<int>() { 4, 8, 3 };
        //    list.Sort();
        //    Print(list);
        //    List<Player> players = new List<Player>() { 
        //        new Player { Name = "Bogdan", Number = 2 }, 
        //        new Player { Name = "Alex", Number = 3 } 
        //    };
        //    players.Sort();

        //Canvas canvas = new Canvas();
        //canvas.Paint(new Circle());
        //List<int> list = new List<int>() { 4, 8, 3 };
        //Print(list);
        //int[] arr = new int[3] { 8, 9, 0 };
        //Print(arr);
        //LinkedList<int> list2 = new LinkedList<int>();
        //list2.AddFirst(1);
        //list2.AddLast(2);
        //list2.AddLast(10);
        //Print(list2);
        //Queue<int> queue = new Queue<int>(); //FIFO
        //queue.Enqueue(1);
        //queue.Enqueue(2);
        //queue.Enqueue(3);
        //Print(queue);


        Team team = new Team("Test Team");
        team.AddPlayer(new Player() { Name = "Bob", Number = 12 });
        team.AddPlayer(new Player() { Name = "John", Number = 10 });
        team.AddPlayer(new Player() { Name = "Frank", Number = 2 });
        foreach (Player player in team)
        {
            Console.WriteLine(player);
        }
        team.Sorting();
        foreach (Player player in team)
        {
            Console.WriteLine(player);
        }


        //List<string> names = new List<string>();
        //names.Add("Bob");
        //names.Add("Alice");
        //names.Add("John");
        //foreach (var name in names)
        //{
        //    Console.WriteLine(name);
        //}

        //Box<int> box1 = new Box<int>(10);
        //Console.WriteLine(box1.GetValue());
        //Box<string> box2 = new Box<string>("Hi");
        //Console.WriteLine(box2.GetValue());

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
