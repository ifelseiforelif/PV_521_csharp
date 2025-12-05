namespace Less1_intro;

internal class Program
{
    static void Main(string[] args)
    {
        ////Int32 number = 5;
        //byte smallByte = 255; //1 byte
        //short smallNumber = 5; //2 bytes
        //int number = 5; //4 bytes
        //long bigNumber = 5000000000L;//8 bytes
        //float realNumber = 5.99f;// 4 bytes
        //double bigRealNumber = 19.99; //8 bytes
        //decimal preciseRealNumber = 19.99m;//16 bytes
        //char character = 'A';// 2 bytes
        //bool isTrue = true;// 1 byte
        //int n = 5, m =9;
        //Console.Write(n+"\n");
        //Console.WriteLine("n={0} m={1}", n, m);
        //Console.WriteLine($"n={n} m={m}");//інтерполяція
        //Console.WriteLine("n: "+n+" m: "+m);
        //Console.WriteLine("Enter name: ");
        //string? name = Console.ReadLine();
        //Console.WriteLine($"Welcome {name}");
        //int a;
        //Console.WriteLine("Enter a number: ");
        ////a = int.Parse(Console.ReadLine());
        //a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Answer: "+a);
        //int i = 0;
        //while(i < 5)
        //{
        //    Console.WriteLine("i= " + i);
        //    i++;
        //}
        //Math.Pow(2, 3);
        int num, sum = 0, mult = 1, min=0, max=0;
        const int N = 5;
        for(int i=0;i<N;i++)
        {
            Console.WriteLine("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            sum += num;
            mult *= num;
            if(i==0)
            {
                min = num;
                max = num;
            }
            else
            {
                if(num>max)
                {
                    max = num;
                }
                if(num<min)
                {
                    min= num;
                }

            }

        }
        Console.WriteLine($"Min: {min} Max: {max} Sum: {sum} Mult: {mult}");
    }
}
