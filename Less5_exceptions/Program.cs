using Less5_exceptions;
using MyMathLibrary;

Console.WriteLine(MyMath.GetSum(4, 5));
Console.WriteLine(MyMath.GetSubstract(4, 5));
int a, b;

try
{
    Test();
}
catch(MyException ex)
{
    Console.WriteLine(ex.Message);
}
while(true)
{
    if(int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
    {

        try
        {
            Console.WriteLine(MyDivide(a, b));
        }
        catch (DivideByZeroException ex)
        {
            //Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {

        }
        break;
    }
    else
    {
        Console.WriteLine("Your data are not int. Try again");
    }
    
}
  Console.WriteLine("Hello WOrld!");

static void Test()
{
    throw new MyException("This is my error");
}
static int MyDivide(int a, int b)
{
    int[] arr = { 4, 6 };
    Console.WriteLine(arr[2]);
       return a / b;
}


//Cat c = new Cat();
//Console.WriteLine(c);
//struct Cat
//{
//    string name;
//    short age;
//    public override string ToString()
//    {
//        return "I am cat";
//    }
//}


