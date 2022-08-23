using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo
{
    class Inheritance
    {
        static void Main(string[] args)
        {
            Account basic = new Account(5.00m);
            SavingsAccount savings = new SavingsAccount(15.00m, 0.05m);
            CheckingAccount checking = new CheckingAccount(50.00m, 0.5m);

            Console.WriteLine("Basic:" + basic.Balance);
            basic.Credit(5.00m);
            Console.WriteLine($"+5.00$ = {basic.Balance}");
            basic.Debit(7.00m);
            Console.WriteLine($"-7.00$ = {basic.Balance}");

            Console.WriteLine("Checking: "+checking.Balance);
            checking.Credit(5.00m);
            Console.WriteLine($"+5.00$ = {checking.Balance}");
            checking.Debit(7.00m);
            Console.WriteLine($"-7.00$ = {checking.Balance}");

            Console.WriteLine("Savings: " + savings.Balance);
            checking.Credit(5.00m);
            Console.WriteLine($"Interest (1%): {savings.CalculateInterest()}");
        }
    }
    public class Account
    {
        private decimal balance;
        public decimal Balance 
        {
            get { return balance; }
            set { balance = value; if (balance + value < 0) { throw new ArithmeticException($"Balance cannot be less than zero {balance - value}"); } }
        }
        public Account(decimal InitialBalance)
        {
            Balance = InitialBalance;
        }
        public virtual void Credit(decimal amount) { Balance += amount; }
        public virtual void Debit(decimal amount) { Balance -= amount; }
    }
    public class SavingsAccount : Account
    {
        decimal interest;
        public SavingsAccount(decimal InitialBalance, decimal InterestRate) : base(InitialBalance)
        {
            interest = InterestRate;
        }
        public decimal CalculateInterest() { return Balance * interest; }
    }

    public class CheckingAccount : Account
    {
        decimal fee;
        public CheckingAccount(decimal InitialBalance, decimal TransactionFee) : base(InitialBalance)
        {
            fee = TransactionFee;
        }
        public override void Credit(decimal amount) 
        {
            base.Credit(amount - fee);
        }
        public override void Debit(decimal amount)
        {
            if (Balance - (amount + fee) < 0)
            {
                base.Debit(amount + fee);
            }
            else { Console.WriteLine("Insufficient Balance"); }
        }
    }
}
