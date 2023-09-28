namespace lab42
{
    public delegate void Event(int balance);
    public class Account
    {
        int balance;
       public event Event events;
        public Account() { }
        public Account(int balance) { this.balance = balance; }
        public void OnBalnceChanged(int newbalance)
        {
            events.Invoke(newbalance);
        }
        public void Transaction(int amount)
        {
            
                balance += amount;
            OnBalnceChanged(balance);
            
        }
    }
    class Program

    {   public static void Changed(int newbalance)
        {
            Console.WriteLine("New Balance: " + newbalance);
        }

        static void Main(string[] args)
        {
            Account account = new Account();
            account.events += Changed;

            account.Transaction(1000);
            account.Transaction(1000);
            Console.ReadLine();
        }
    }
}