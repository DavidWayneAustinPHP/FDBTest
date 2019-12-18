using System;

namespace FDBTest
{
    public class BankAccount
    {
        string _customerName;
        double _balance;

        public BankAccount(string customerName, double balance)
        {
            _customerName = customerName;
            _balance = balance;
        }

        public double Balance { get { return _blance; } }
    }
}

