using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work;

namespace Work
{
    enum AccountType { Current, Savings }
    internal class Bank
    {
        int AccountNumber;
        decimal Balance;
        AccountType Type;
        public string GetTitle { get { return $"id:{AccountNumber}.Balance:{Balance}.Type:{Type}"; } }
        static public bool operator ==(Bank b1, Bank b2)
        {
            if (b1.GetTitle.Equals(b2.GetTitle))
                return true;
            return false;
        }
        static public bool operator !=(Bank b1, Bank b2)
        {
            if (!b1.GetTitle.Equals(b2.GetTitle))
                return true;
            return false;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Bank)
            {
                Bank NN = (Bank)obj;
                if (NN.GetTitle == this.GetTitle)
                    return true;
            }
            return false;
        }
        public Bank(int AccountNumber, decimal Balance, AccountType Type)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
            this.Type = Type;
        }
        public override string ToString()
        {
            return this.GetTitle;
        }
        public string GetAndSetAccountNumber { get; set; }
        public decimal GetAndSetBalance { get { return Balance; } set { Balance = value; } }
        public AccountType GetAndSetType { get; set; }

        static Random rand = new Random();
        private static int generic_number = rand.Next(0, 10000000);
        public int Generic
        {
            get { return generic_number; }
            set { value = generic_number++; }
        }
        public void PutOnBalance()
        {
            Console.Write("Введите сумму для зачисления ");
            Balance += decimal.Parse(Console.ReadLine());
        }
        public void PutOutBalance()
        {
            Console.Write("Введите сумму для снятия ");
            try
            {
                decimal temp = Convert.ToDecimal(Console.ReadLine());
                if (Balance >= temp)
                    Balance = Balance - temp;
                else
                {
                    Console.WriteLine("На вашем счёте недостаточно средств(...");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
