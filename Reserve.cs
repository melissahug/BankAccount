﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Reserve : Account
    {
        //field
        double beginningBalance;
        double currentBalance;



        //properties
        //member should be able to get their account number and balance but not make any changes
        public double BeginningBalance
        {
            get { return this.beginningBalance; }
        }

        public double CurrentBalance
        {
            get { return this.currentBalance; }
        }

        //constructor
        //setting the balance to 
        public Reserve(double currentBalance)
        {
            this.currentBalance = currentBalance;
        }

        //method
        //when any of these methods are called, they will either deduct or add from the current balance
        public void AddToBal()
        {

            Console.WriteLine("How much would you like to deposit?");
            double deposit = double.Parse(Console.ReadLine());
            currentBalance = currentBalance + deposit;
            Console.WriteLine("Your deposit is (+)$" + deposit);
            Console.WriteLine("Your current balance is: " + currentBalance);
        }

        public void DeductFromBal()
        {
            Console.WriteLine("How much would you like to withdrawl?");
            double withdraw = double.Parse(Console.ReadLine());
            currentBalance = currentBalance - withdraw;
            Console.WriteLine("Your withdrawl is (-)$" + withdraw);
            Console.WriteLine("Your current balance is " + currentBalance);

            //C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\BankAccountProject\BankAccountProject\obj\Debug\MemberStatements
        }
    }
}
