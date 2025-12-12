namespace Less6_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(10);
            student.MyAge = 12; //set 
            Console.WriteLine(student.MyAge);
        }
    }
}
