using System.Diagnostics;
using System.Text;
using System;

//CLR - загальномовна середа виконання Common Language Runtime
//буфер інтернування
namespace Less3_array_string
{
    internal class Program
    {
        static void Print2DArray(int[,] arr2D)
        {
            for (uint i = 0; i < arr2D.GetLength(0); i++)
            {
                for (uint j = 0; j < arr2D.GetLength(1); j++)
                {
                    Console.Write($"{arr2D[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void changeArr(ref int[] arr, int value)
        {
            arr = new int[3] { 1, 1, 1 };
        }
        static string createStr(int i)
        {
            return "A" + (char)((int)('A') + i);
        }
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                Console.WriteLine(Convert.ToInt32(args[0])+ Convert.ToInt32(args[1]));
            }
            //string s7 = "AB";
            //string s8 = createStr(1);
            //Console.WriteLine($"{s7} {s8}");
            //Console.WriteLine(String.ReferenceEquals(s7,s8));

        
            //uint size = 5;
            //int[] arr = { 5, 3, 4, 5, 6 };
            // int[] arr2 = new int[size];

            //int n = 12;
            //Console.WriteLine(n.CompareTo(12)); 

            //ASC - за зростанням
            //DESC - за спаданням
            //Array.Sort(arr ,(n1, n2) => n2.CompareTo(n1)); 
            //Array.Reverse(arr);
            //Console.WriteLine(Array.IndexOf(arr, 3));
            //Console.WriteLine(Array.LastIndexOf(arr,5));
            //Console.WriteLine(Array.Find(arr, el => el %2==0));
            //int[] result = Array.FindAll(arr, el=>el>3);
            //for(int i=0;i<result.Length;i++)
            //{
            //    Console.Write(result[i]+" ");
            //}

            //foreach (var el in result)
            //{
            //    Console.WriteLine(el);
            //}
            //Console.Write("\n\n");
            //foreach(var el in arr)
            //{
            //    Console.Write($"{el} ");
            //}
            //Console.WriteLine(Array.Exists(arr, el => el <20));
            //int[] new_arr = new int[arr.Length];
            //Array.Copy(arr, new_arr, arr.Length);
            //Array.Clear(arr, 2,2);
            //Array.Clear(arr);
            //foreach (int el in arr)
            //{
            //    Console.WriteLine(el);
            //}
            // Array.ForEach(arr, el => Console.WriteLine(el*2));
            //arr.Sum();
            //arr.Average();
            //arr.Min();
            //arr.Max(); 


            //Array.Resize(ref arr, 3);

            //Array.ForEach(arr, el => Console.WriteLine(el));

            ////int[] arr3 = arr; 
            //double m = 3.45277;
            //Console.WriteLine(Math.Round(m, 2));

            //Console.WriteLine(String.Format("{0:0.00} ", m));
            //double[] arr6 = { 3.0, 6.0, 8.0, 7.0, 2.0, 1.0 };


            //double sum = arr6.Sum();
            //double max = arr6.Max();
            //double min = arr6.Min();
            //double avarage = arr6.Average();
            //Console.WriteLine(sum);
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Console.WriteLine(avarage);

            //int[,] arr2D = { { 3,4},{5,6 },{7,8 } };
            //Random rand = new Random();


            //for (uint i = 0; i < arr2D.GetLength(0); i++)
            //{
            //    for (uint j = 0; j < arr2D.GetLength(1); j++)
            //    {
            //        arr2D[i,j] = rand.Next(-10, 10);
            //    }
            //}
            //Print2DArray(arr2D);
            //int[] arr222 = arr2D.Cast<int>().ToArray();
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //int k = 0;
            //for (uint i = 0; i < arr2D.GetLength(0); i++)
            //{
            //    for (uint j = 0; j < arr2D.GetLength(1); j++)
            //    {
            //        arr2D[i, j] = arr[k++];

            //    }
            //}
            //Print2DArray(arr2D);
            //arr2D.GetValue(2, 3);
            //arr2D.SetValue(2,3,100);

            //int[,] arr2D2 =
            //{
            //    {3,4 ,6},
            //    {5,7 ,7}
            //};
            //Рядки
            //String str1 = new String("Hello");
            //String str2 = new String('*', 5);
            //string str3 = "Hello"; //рядки immutable
            //string str4 = new string("Hello");
            //string str5 = "Hello";  
            //Console.WriteLine(str3.Equals(str4)); //КОНТЕНТ
            //Console.WriteLine(string.ReferenceEquals(str3, str5));



            //str4 += " World";




            //Console.WriteLine(str4.Length);

            Stopwatch timer = new Stopwatch();
            timer.Start();
            //string s = String.Empty;
            //for (uint i = 0; i < 100000; i++)
            //{
            //    s += "hi ";
            //}
            //timer.Stop();
            //Console.WriteLine(timer.ElapsedMilliseconds + " ms");

            //StringBuilder stringBuilder = new StringBuilder(1000);
            //for (uint i = 0; i < 100000; i++)
            //{
            //    stringBuilder.Append("hi ");
            //}
            //timer.Stop();
            //Console.WriteLine(timer.ElapsedMilliseconds + " ms");
            // Console.WriteLine(stringBuilder.ToString());
            // string str = "   Hello"; // "Hello"
            //str = str + " World";
            // str += " World.   "; //"Hello World"
            string str = "9.gjgjg";
            Console.WriteLine(str.StartsWith("9"));
            Console.WriteLine(str.EndsWith("."));
            Console.WriteLine(str.Contains("test"));
            string str2 = str.Trim(); //прибирає пробели
            str.TrimStart(); 
            str.TrimEnd();
            //Console.WriteLine(str2);
            //IndexOf, LastIndexOf
            //double x = 5.63747;
            //Console.WriteLine(String.Format("{0:0.00}", x));
            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.ToLower());
            //string fruits = "banana,lemon,orange";
            //string[] result = fruits.Split(',');
            //foreach (string str2 in result)
            //{
            //    Console.WriteLine(str2);
            //}
            //Console.WriteLine(String.Join(' ', result));
            Console.WriteLine(str.Replace(" ", ""));
            //StringBuilder

            //string s1 = "Hello";
            //string s2 = "Hello";
            //s1 += " Bye";
            //String.Intern(s2);
            string s1 = "AB";
            string s2 = "A" + "B";
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(String.ReferenceEquals(s1,s2));
        }
    }
}
