namespace Delegate
{
    public delegate void MyDelegate(string msg);
    class MyClass
    {
        public static void Print(String msg) => Console.WriteLine($"{msg.ToUpper()}");
        public static void Show(String msg) => Console.WriteLine($"{msg.ToLower()}");
        public static void Display(String msg) => Console.WriteLine($"{msg}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Multicasst Delegate";
            MyDelegate m1 = MyClass.Print;
            MyDelegate m2 = MyClass.Show;
            Console.WriteLine("Ca 2");
            MyDelegate m3 = m1 + m2;
            m3(msg);
            Console.WriteLine("Ca 3");
             m3 += MyClass.Display;
            m3(msg);
            Console.WriteLine("Xoa 2");
            m3 -= m2;
            m3("Oke");
            Console.ReadLine();

        }
    }
}