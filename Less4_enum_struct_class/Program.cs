namespace Less4_enum_struct_class
{
    struct Point2D
    {
        public int x;
        public int y;
        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
    class Point3D
    {
        private int x;
        private int y;
        private int z;
        public Point3D(int x, int y, int z)
        {
            this.x=x;
            this.y=y;
            this.z=z;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public override string ToString()
        {
            return $"x{x} y{y} z{z}";
        }
    }


    internal class Program
    {
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
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(2, 3,7);
            Change(p1);
            Console.WriteLine(p1);

            //Point2D p1 = new Point2D(2, 3);
            //Change(p1);
            //Console.WriteLine(p1.x); 


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
    }
}
