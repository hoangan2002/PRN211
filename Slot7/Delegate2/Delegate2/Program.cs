namespace Delegate
{
    public delegate void MyDelegate(string msg);
    class MyClass
    {
        public static void print(string msg) => Console.WriteLine($" {msg.ToUpper()}   ");
        public static void show(string msg) => Console.WriteLine($" {msg.ToLower()}   ");
        
    }
    class Program
    {
        static void InvokeDelegate(MyDelegate dele, string msg) =>dele(msg);
        static void Main(string[] args)
        {
            string msg = "Passing Delegate As A Parameter";
            InvokeDelegate(MyClass.print, msg);
            InvokeDelegate(MyClass.show, msg);
            Console.ReadLine();
        }
    }
}