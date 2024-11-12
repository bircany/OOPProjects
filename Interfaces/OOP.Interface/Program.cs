using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var saver = new SaverAccount();
            saver.PayIn(500);
            saver.Withdraw(300);
            saver.Withdraw(500);
            Console.WriteLine("Current Balance = " + saver.Balance);
            Console.WriteLine(saver);


            Console.ReadKey();
        }
    }
}
