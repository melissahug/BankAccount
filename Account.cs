using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class Account
    {

        //field

        string memberName;
        public double memberNumber;

        //properties

        //get and set for the member name because they should be able to retrieve and change their name
        public string MemberName
        {
            get { return this.memberName; }
            set { this.memberName = value; }
        }

        //this should be a get only because their member number should be seen but members should not be able to make changes
        public double MemberNumber
        {
            get { return this.memberNumber; }
        }
        //constructor
        //none created


        //method
        //This method will display them member name when requested. 
        public void Greeting(string memberName, double memberNumber)
        {
            Console.WriteLine("Welcome to \"We Can CODE IT\" Bank of Cleveland\nHello " + memberName + ", your account number is: " + memberNumber);
        }

       }
    }

