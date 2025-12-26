using System.Diagnostics;

namespace Less7;

interface IShape
{   
    void Draw();
}
class Square : IShape
{
    public Square()
    {
        Console.WriteLine("I am ctor Square");
    }
 
    public void Draw()
    {
        Console.WriteLine("Draw square....");
    }
}

class Circle : IShape
{
    public Circle()
    {
        Console.WriteLine("I am ctor Circle");
    }
    public void Draw()
    {
        Console.WriteLine("Draw Circle....");
    }
}

class Rectangle : IShape
{
    public Rectangle()
    {
        Console.WriteLine("I am ctor Circle");
    }

    public void Draw()
    {
        Console.WriteLine("Draw Rectangle....");
    }

}



class MyCanvas
{
    public void Paint(IShape sh)
    {
        sh.Draw();

    }

}

internal class Program
{
    static void Main(string[] args)
    {
        //MyCanvas canvas = new MyCanvas();
        //int choice;
        //while (true)
        //{
        //    Console.WriteLine($"Square - 1, Circle - 2, Rect - 3: ");
        //    IShape? shape = null;
        //    if (Int32.TryParse(Console.ReadLine(), out choice))
        //    {
        //        switch (choice)
        //        {
        //            case 1:
        //                shape = new Square();
        //                break;
        //            case 2:
        //                shape = new Circle();
        //                break;
        //            case 3:
        //                shape = new Rectangle();
        //                break;
        //        }
        //        if (shape != null)
        //        {
        //            canvas.Paint(shape);
        //        }
        //    }
        //}
        IShape[] shapes = { new Square(), new Circle(), new Rectangle() };
        foreach (IShape shape in shapes) 
            {
                shape.Draw();
            }

    }
}
/*
 * Card (abstract class) (конструктор приймає комісію), баланс, сума списання
 * abstract метод СписанняБаланса
 * MonoBankCard, PrivateBankCard, ABankCard
 * 
 * Зробити клас ATM
 * і метод класа який на вхід приймає картку банка
 * і робить списання коштів
 * 
 * Протестувати роботу системи в Main
 * 
 * 
 */


/*
 * Зробити класи Scaner, Printer, Copier, MultiDevice
 * 
 * Розробити інтерфейси, які будуть реалізовуватись даними класами
 * 
 * Зробити метод
 * On, Off, Copy, Print, Scan
 * 
 * 
 * 
 * 
 * 
 */