namespace Delegate
{
    public delegate int myDelegate(int numOne, int numTwo);
    class Program
    {
        static int Add(int numOne, int numTwo) => numOne + numTwo;
        static int Subtract(int numOne, int numTwo) => numOne - numTwo; 
        static void Main(string[] args)
        {
            int n1 = 25; int n2 = 15;
            int result;
            myDelegate a = new myDelegate(Add);
            result = a(n1,n2);
            Console.WriteLine(result);
            a = Subtract; result = a(n1,n2);

            Console.WriteLine(result);
            result = a.Invoke(n1,n2);
            Console.Write(result);
            Console.ReadLine();
        }
    }
}