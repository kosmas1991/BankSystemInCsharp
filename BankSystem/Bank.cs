using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class Bank
    {
        List<Branch> branches;
        string name;

        public Bank(string name)
        {
            this.branches = new List<Branch>();
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        internal List<Branch> Branches { get => branches; set => branches = value; }

        public void addBranch(string branchName) {
            branches.Add(new Branch(branchName,Name));
            Console.WriteLine("Bank " + Name + " created!");
        }

        public Branch getBranchByName(string onoma)
        {
            foreach (Branch branch in branches)
            {
                if(branch.Name.Equals(onoma))
                {
                    return branch;
                }
            }
            return null;
        }
    }
}
