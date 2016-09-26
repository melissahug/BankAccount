using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Account firstMemberName = new Account();
            firstMemberName.Greeting("Jack Jones", 456778);
            Checking jackCheckBal = new Checking(0);
            Saving jackSaveBal = new Saving(0);
            Reserve jackReservBal = new Reserve(0);

           
            Console.WriteLine("Please choose from the following: \n1) Checking \n2) Saving \n3) Reserve");

            int userOption = int.Parse(Console.ReadLine());
            if (userOption == 1)

            {
                Console.WriteLine("CHECKING\nYour current Balance is: ");
                Console.WriteLine("To make a deposit, press 1,\nTo get a withdrawl, press 2\n, To exit, press 3\n");

                //request user to obtain deposit information 
                int checkingOption = int.Parse(Console.ReadLine());

                if (checkingOption == 1)
                {
                    Console.WriteLine("You want to make a deposit");
                    jackCheckBal.AddToBal();
                }

                else if (checkingOption == 2)
                {
                    Console.WriteLine("You want to withdraw funds.");
                    jackCheckBal.DeductFromBal();
                }
                else if (checkingOption == 3)
                {
                    Console.WriteLine("Thank you. Have a great day!");
                    Environment.Exit(0);
                }

                else if (userOption == 2)
                {
                    Console.WriteLine("SAVING\nYour current Balance is: ");
                    Console.WriteLine("To make a deposit, press 1,\nTo get a withdrawl, press 2\n, To exit, press 3\n");

                    //request user to obtain deposit information 
                    int savingOption = int.Parse(Console.ReadLine());

                    if (savingOption == 1)
                    {
                        Console.WriteLine("You want to make a deposit");
                        jackSaveBal.AddToBal();
                    }

                    else if (savingOption == 2)
                    {
                        Console.WriteLine("You want to withdraw funds.");
                        jackSaveBal.DeductFromBal();
                    }
                    else if (savingOption == 3)
                    {
                        Console.WriteLine("Thank you. Have a great day!");
                        Environment.Exit(0);
                    }

                }
                else if (userOption == 3)
                {
                    Console.WriteLine("RESERVE\nYour current Balance is: ");
                    Console.WriteLine("To make a deposit, press 1,\nTo get a withdrawl, press 2\n, To exit, press 3\n");

                    //request user to obtain deposit information 
                    int reserveOption = int.Parse(Console.ReadLine());

                    if (reserveOption == 1)
                    {
                        Console.WriteLine("You want to make a deposit");
                        jackReservBal.AddToBal();

                    }

                    else if (reserveOption == 2)
                    {
                        Console.WriteLine("You want to withdraw funds.");
                        jackReservBal.DeductFromBal();

                    }
                    else if (reserveOption == 3)
                    {
                        Console.WriteLine("Thank you. Have a great day!");
                        Environment.Exit(0);

                    }
                }
            }
        }
    }
}
