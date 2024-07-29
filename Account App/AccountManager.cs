namespace MyBankingApp
{
    internal class AccountManager
    {
        List<Account> Accounts = new List<Account>();

        Account a = new Account();

        public AccountManager()
        {
            Accounts = SerializDeseializ.DeserializeData();
            CallMainMenu();
            //SerializDeseializ.SerializeData(Accounts);
        }

        public void CallMainMenu()
        {
            Console.WriteLine("Choose the following : " + "\n 1.Create New Account " + "\n 2.Work With Existing Account" + "\n 3.Exit");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                CreateAccount(Accounts);
            }
            else if (input == 2)
            {
                CallSubMenu();
            }
            else if (input == 3)
            {
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }

        public void CreateAccount(List<Account> AccList)
        {
            Console.WriteLine("Enter Id :");
            int id = int.Parse(Console.ReadLine());

            foreach (Account acc in AccList)
            {
                if (id == acc.PersonId)
                {
                    Console.WriteLine("Account already exists.");
                    return;
                }

            }

            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Balance :");
            double balance = double.Parse(Console.ReadLine());

            Account a = new Account(id, name, balance);
            Accounts.Add(a);
            SerializDeseializ.SerializeData(Accounts);
            CallMainMenu();


        }

        public void CallSubMenu()
        {

            Console.WriteLine("Enter Account Number : ");
            int inpNum = int.Parse(Console.ReadLine());

            foreach (Account acc in Accounts)
            {
                if (inpNum == acc.PersonId)
                {
                    Operations(acc);
                    return;
                }

            }
            SerializDeseializ.SerializeData(Accounts);
            Console.WriteLine("Account not found.");

        }


        public void WithdrawMoney(Account acc)
        {
            Console.WriteLine("Enter the amount to be withdraw : ");
            double withdraw = double.Parse(Console.ReadLine());
            acc.Withdraw(withdraw);
            SerializDeseializ.SerializeData(Accounts);

        }

        public void DepositMoney(Account acc)
        {
            Console.WriteLine("Enter the amount to be deposited : ");
            double depo = double.Parse(Console.ReadLine());
            acc.Deposit(depo);
            SerializDeseializ.SerializeData(Accounts);

            Console.WriteLine("Amount deposited sucessfully.");

        }

        public void PrintDetails(Account acc)
        {
            int labelWidth = 20;
            int valueWidth = 30;

            Console.WriteLine("+" + new string('-', labelWidth) + "+" + new string('-', valueWidth) + "+");
            Console.WriteLine("| {0," + (-labelWidth) + "} | {1," + (-valueWidth) + "} |", "Label", "Value");
            Console.WriteLine("+" + new string('-', labelWidth) + "+" + new string('-', valueWidth) + "+");  // Separator line

            Console.WriteLine("| {0," + (-labelWidth) + "} | {1," + (-valueWidth) + "} |", "Account Number:", acc.PersonId);
            Console.WriteLine("| {0," + (-labelWidth) + "} | {1," + (-valueWidth) + "} |", "Name of User:", acc.PersonName);
            Console.WriteLine("| {0," + (-labelWidth) + "} | {1," + (-valueWidth) + "} |", "Balance:", acc.Balance);

            Console.WriteLine("+" + new string('-', labelWidth) + "+" + new string('-', valueWidth) + "+");
        }


       
        public void Operations(Account passAccount)
        {
            char choiceAccount = 'y';
            do
            {
                
                Console.WriteLine("Chose the following : 1.Withdraw 2.Deposit 3.Print Details 4.Back 5.Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        WithdrawMoney(passAccount);
                        break;
                    case 2:
                        DepositMoney(passAccount);
                        break;
                    case 3:
                        PrintDetails(passAccount);
                        break;

                    case 4:
                        CallMainMenu();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("Do you wish to continue with the same account Y/N ");
                choiceAccount = char.Parse(Console.ReadLine());
            } while (choiceAccount == 'Y' || choiceAccount == 'y');

        }

    }
}
