using StateDesignPattern.Model;

class Program
{
    public static void Main(string[] args)
    {
        ATMmachine machine = new ATMmachine();
        Console.WriteLine("Current state  : " + machine.atm.GetType().Name);
        Console.WriteLine();
        machine.EnterPin();
        machine.WithdrawMoney();
        machine.InsertDebit();

        Console.WriteLine();

        Console.WriteLine("Current state  : " + machine.atm.GetType().Name);
        Console.WriteLine();
        machine.EnterPin();
        machine.WithdrawMoney();
        

    }
}