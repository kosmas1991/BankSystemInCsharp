﻿using System;

namespace BankSystem
{
    class Mainprogram
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Bank ethniki = new Bank("ethniki");
            ethniki.addBranch("kozanis");
            Console.WriteLine(ethniki.getBranchByName("kozanis").Name);
            ethniki.getBranchByName("kozanis").addCustomer("midas");
            Console.WriteLine("Search for " +ethniki.getBranchByName("kozanis").getCustomerByName("midas"));

            // etc ...
        }
    }
}
