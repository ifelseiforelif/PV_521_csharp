namespace Less8_delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyButton button = new MyButton();
            button.evClick += () => Console.WriteLine("Subscriber 1");
            button.evClick += () => Console.WriteLine("Subscriber 2");
            button.evClick += () => Console.WriteLine("Subscriber 3");
            button.OnClick();

       
        }
    }
}
