using System.Collections.Generic;

namespace BankApp
{
    public interface IAccountActivity
    {
        void AddActivity(string activity);
        List<string> GetActivities();
    }
}
