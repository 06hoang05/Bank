using System;
using System.Collections.Generic;

using System.Text;


namespace C_BankApplication
{
    internal class Customer
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;
        public Customer(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = new List<BankAccount> ();
        }
    }
}
