using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Program //week3
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000,"Bircan","Yılmaz",DateTime.Now);
            //account.CheckAccount();
            //account.Deposit(500);
            //account.Withdraw(200);
            //account.ShowAccountActivities();
           
            BankApp.StartBankApp(account);
            

            Console.ReadKey();
        }
       
    }
}
