using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public interface IAccount
    {
        double Balance { get; }
        void CheckAccount();
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}
