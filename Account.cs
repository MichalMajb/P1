﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    abstract class Account
    {
        public string AccountNumber;
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;

        public Account(string accountNumber, decimal balance, string firstName, string lastName, long pesel)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
        }
        public abstract string TypeName();

        public string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);


        }
        public string GetBalance()
        {
            return string.Format("Balans: {0}zł", Balance);
        }
    }
}