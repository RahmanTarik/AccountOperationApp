using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationApp
{
    internal class Account
    {
        public string customerName;
        public string accountNumber;
        public double balance = 0;

        public string Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return "Taka " + amount + " Deposited";
            }

            return "Please Enter Valid Amount";
        }

        public string Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (balance - amount >= 0)
                {
                    balance -= amount;
                    return "Taka " + amount + " Has been Withdrawn";
                }
                    return "Insuficient Balance";
                }
            
                return "Please Enter Valid Amount";
            }
    }
}
