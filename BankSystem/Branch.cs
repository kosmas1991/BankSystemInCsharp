using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class Branch
    {
        List<Customer> customers;
        string name;
        string bankName;

        public Branch(string name,string bankName)
        {
            this.customers = new List<Customer>();
            this.name = name;
            this.bankName = bankName;
        }

        public string BankName { get => bankName; set => bankName = value; }
        public string Name { get => name; set => name = value; }
        internal List<Customer> Customers { get => customers; set => customers = value; }
    }
}
