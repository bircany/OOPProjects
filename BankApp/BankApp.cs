using BankApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class BankApp
    {
        public static void StartBankApp(BankAccount account)
        {
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("\n=== Bank Account Menu === \n 1. Check Balance \n 2. Deposit \n 3. Withdraw \n 4. Show Account Activities \n 5. Exit \n Choose an option (1-5): ");
                string option = Console.ReadLine();
                double amount;
                switch (option)
                {
                    case "1":
                        account.CheckAccount();
                        break;
                    case "2":
                        Console.WriteLine("How much do you want a deposit?: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(amount);
                        break;
                    case "3":
                        Console.WriteLine("How much do you want a withdraw?: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        account.Withdraw(amount);
                        break;
                    case "4":
                        Console.WriteLine("Account Activities:");
                        account.ShowAccountActivities();
                        break;
                    case "5":
                        flag = true;
                        Console.WriteLine("Exiting the Bank Menu. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option (1-5).");
                        break;
                }
            }
        }

    }
}
