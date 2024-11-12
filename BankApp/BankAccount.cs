using System;

namespace BankApp
{
    public class BankAccount : IAccount
    {
        public double Balance { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public DateTime AccountDate { get; set; }

        private readonly IAccountActivity accountActivity;
        public BankAccount(double balance, string firstName, string lastName, DateTime accountDate)
        {
            Balance = balance;
            FirstName = firstName;
            LastName = lastName;
            AccountDate = accountDate;
            this.accountActivity = new AccountActivity();  
        }

        public void CheckAccount()
        {
            Console.WriteLine($"Account Balance:{Balance}");
        }

        public void Deposit(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new InvalidOperationException("Geçersiz yatırma tutarı. Yatırmak istediğiniz tutar sıfırdan büyük olmalıdır.");
                }

                Balance += amount;
                accountActivity.AddActivity($"{DateTime.Now}: Deposited {amount}");
                Console.WriteLine("İşlem başarılı.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }

        public void Withdraw(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new InvalidOperationException("Geçersiz çekim tutarı. Lütfen sıfırdan büyük bir tutar girin.");
                }
                else if (amount > Balance)
                {
                    throw new InvalidOperationException("Çekmek istediğiniz tutar mevcut bakiyeden fazla,Yetersiz bakiye. ");
                }

                Balance -= amount;
                accountActivity.AddActivity($"{DateTime.Now}: Withdraw {amount}.");
                Console.WriteLine("İşlem başarılı.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }

        }
        public void ShowAccountActivities()
        {
            foreach (var activity in accountActivity.GetActivities())
            {
                Console.WriteLine(activity);
            }
        }
    }
}
