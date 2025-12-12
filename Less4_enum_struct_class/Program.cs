namespace Less4_enum_struct_class;
using Model;


enum Role : byte
{
    Admin = 1 ,
    User,
    Manager 
}

internal class Program
{
    static void Main(string[] args)
    {

        //Object[] obj = { 4, 7.6, "hello", new Point2D(), new Point3D(5,6,7) };
        //int x = (int)(obj[0])+1;
        //string s = (string)obj[2];





        int code;
        Console.WriteLine("Make your choice: ");
        foreach(var el in Enum.GetValues(typeof(Role)))
        {
         
            Console.WriteLine($"Role {el} : {(byte)el}");
        }
        //if(int.TryParse(Console.ReadLine(), out code))
        //{
        //    Role role = (Role)code;
        //    switch (role)
        //    {
        //        case Role.Admin:
        //            Console.WriteLine("all rights");
                    
        //    }

        //}
        //else
        //{
        //    Console.WriteLine("Invalid code");
        //}
        //if(int.TryParse(Console.ReadLine(), out code))
        //{
        //    Role role = (Role)code;
        //    switch (role)
        //    {
        //        case Role.Admin:
        //            Console.WriteLine("all rights");
                    
        //    }

        //}
        //else
        //{
        //    Console.WriteLine("Invalid code");
        //}
        //Role role = Role.Admin;
        //Console.WriteLine(role);
        //Console.WriteLine((byte)role);
        //foreach(var el in Enum.GetValues(typeof(Role)))
        //{
        //    Console.WriteLine(el); 
        //}

        //Point3D p1 = new Point3D(2, 3,7);
        //Change(p1);
        //Console.WriteLine(p1);

        //Point2D p2 = new Point2D(2, 3);
        //Change(p2);
        //Console.WriteLine(p2.x);


        //int x;
        //TestOut(out x);
        //Console.WriteLine(x);

        //int x = 10;
        //Change(ref x);
        //Console.WriteLine(x);
        //int[] arr = { 1, 2, 3 };
        //change(arr);
        //foreach (int el in arr)
        //{
        //    Console.WriteLine(el);
        //}
        //int x = 10;
        //change(x);
        //Console.WriteLine(x++);
    }

    static void Change(ref int y)
    {
        ++y;
    }
    static void Change(int[] arr)
    {
        arr[0] = 19;
    }
    static void TestOut(out int x)
    {
        x = 19;
    }
    static void Change(Point2D point2D)
    {
        point2D.x = 19;
        point2D.y = 20;
    }
    static void Change(Point3D point3D)
    {
        point3D.SetX(100);
    }
}
