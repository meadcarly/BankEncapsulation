using System.Diagnostics;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //In the main method of your application, create a new instance of the BankAccount class. Allow the user of the application to Deposit money and retrieve their balance through the console.
            var bankAccount = new BankAccount();
            int choice;

            while (true)
            {
                Console.WriteLine("Please choose an option to continue");
                Console.WriteLine("1: Deposit");
                Console.WriteLine("2. Check account balance");
                Console.WriteLine("3. Exit");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
                {
                    Console.WriteLine($"Please choose 1, 2, or 3");
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter the amount of your deposit");
                        double depositAmount = 0;
                        while (!double.TryParse(Console.ReadLine(), out depositAmount))
                        {
                            Console.WriteLine("Invalid amount. Please enter a number amount for deposit");
                        }

                        bankAccount.Deposit(depositAmount);
                        break;

                    case 2:
                        double balance = bankAccount.GetBalance();
                        Console.WriteLine($"Your current balance is ${balance}");
                        break;
                    
                    case 3:
                        Console.WriteLine("Exiting...Goodbye!");
                        return;
                    
                    default:
                        Console.WriteLine($"Please choose 1, 2, or 3");
                        break;
                }
            }
        }
    }
}

