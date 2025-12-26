namespace ConsoleApp1
{

    /*
     * const (static)
     * static Italia
     * readonly ()
     */
    //class Cat
    //{
    //    private readonly string _color;
    //    public string Color
    //    {
    //        get { return _color; }
    //    }
    //    //public string Color 
    //    //{ 
    //    //    get { return _color; }

    //    //}

    //    public Cat(string color)
    //    {
    //        _color = color;
    //    }
    //}
    class MyMath
    { 
        public static int GetSum(int a, int b)
        {
            return a + b;
        }
        public static int GetSubstract(int a, int b)
        {
            return a - b;
        }
    }

    
    internal class Program
    {
        private delegate int MyMathDelegate(int a, int b);

        static bool isSuccess(int x)
        {
            return x>0;
        }
        static void Test() { }
        static void Test(int a) { }
        static int GetResult(int a, int b)
        {
            return a + b;
        }
        static void TestArr(int[] arr, Predicate<int> del) { }
        Predicate<int> delPr = isSuccess;
        Func<int, int, int> funcDel = GetResult;
        static void Test(double a, int b) { }
        Action<int> del = Test;
        Action<double,int>  del2= Test;
        Action del3 = Test;

       

        static bool isEqualFive(int el)
        {
            return el == 5;
        }
        static void Main(string[] args)
        {

            Action<int, string> myAction = (x, s) => Console.WriteLine($"Received {x} and {s}");
            myAction(42, "Hello");
            int[] arr = { 5, 6, 2 };
            Array.Find(arr, isEqualFive);
            //MyMathDelegate mydel = new MyMathDelegate(MyMath.GetSum);
           MyMathDelegate mydel = MyMath.GetSubstract;
            Console.WriteLine(mydel(3, 4));
            Console.WriteLine(mydel.Invoke(3,4));
            //string s = "Hello";
            
            //Console.WriteLine(s?.Length);
            //int? y = null;
            //int x = y ?? 10;
            //Console.WriteLine(x);
            //Nullable<int> age = getAgeFromDb();

            //Value, HasValue
            //int? age = getAgeFromDb();


            //if(age.HasValue)
            //{
            //    Console.WriteLine($"Age {age.Value}");
            //}
            //Nullable<int> age;
            //age.Value;
            //age.HasValue;
            //age = null; //Nullable types
        }
    }
}
