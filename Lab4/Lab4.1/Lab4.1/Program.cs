namespace lab41
{
    public delegate void SampleDelegate(int a, int b);
    class MathOperations
    {
        public void Add(int a, int b) {
            Console.WriteLine("Add Result: {0}", a + b);

        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtract Result: {0}", a - b);

        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiply Result: {0}", a * b);

        }
        public void Divide(int a, int b)
        {
            Console.WriteLine("Divide Result: {0}", a/b);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ex");
            MathOperations m = new MathOperations();
            SampleDelegate dlgt = m.Add;
            dlgt += m.Subtract;
            dlgt += m.Multiply;
            dlgt += m.Divide;
            dlgt(91, 10);
            Console.ReadLine();
        }
    }
}