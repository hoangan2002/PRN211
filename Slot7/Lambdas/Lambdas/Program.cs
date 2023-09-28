namespace lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "David", "Jane", "Peter", "John", "Mark" };
            foreach (var item in names.OrderBy(s => s))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}