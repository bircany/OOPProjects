using System;
using System.Collections.Generic;

namespace BankApp
{
    public class AccountActivity : IAccountActivity
    {
        private List<String> activities = new List<String>();
        public void AddActivity(string activity) => activities.Add(activity);
        public List<string> GetActivities() =>  activities;
    
    }
}
