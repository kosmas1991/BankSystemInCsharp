using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class Customer
    {
        List<double> transcactions;
        string branchName;
        string bankName;
        string name;


        public Customer(string name,string branchName,string bankName)
        {
            this.transcactions = new List<double>();
            this.name = name;
            this.branchName = branchName;
            this.bankName = bankName;
        }

        public List<double> Transcactions { get => transcactions; set => transcactions = value; }
        public string BranchName { get => branchName; set => branchName = value; }
        public string BankName { get => bankName; set => bankName = value; }
        public string Name { get => name; set => name = value; }
    }
}
