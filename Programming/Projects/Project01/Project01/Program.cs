//Isaiah Samba 1/27/2022
using System;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            string aucustomer = "isamba";//statement explaining the customer must retrieve withdrawal details

            Console.WriteLine($"{aucustomer} would like to know"

            + " how much would you like to withdraw:\n");//statement to tell the student we are requesting the withdrawal amount

            decimal withdraw_amt = decimal.Parse(s: Console.ReadLine());//Customer information's capture and the datatype is changed to a decimal

            decimal bankNote_50 = (withdraw_amt / 50);// Divides amount provided by the customer by 50 and returns the number of these bills the customer will recieve

            decimal bankNote_50_b = (withdraw_amt % 50);//Returns the remainder of the bill after it is divided

            decimal bankNote_20 = (bankNote_50_b / 20);//Divides the remainder of the previous bill by this smaller bill to see how much the customer wil receive

            decimal bankNote_20_b = (bankNote_50_b % 20);

            decimal bankNote_10 = (bankNote_20_b / 10);

            decimal bankNote_10_b = (bankNote_20_b % 10);

            decimal bankNote_5 = (bankNote_10_b / 5);

            decimal bankNote_5_b = (bankNote_10_b / 1);

            decimal bankNote_1 = (bankNote_5_b / 1);

            decimal bankNote_1_b = (decimal)(bankNote_5_b % 1);// Divides the remainder of the amount by one, and allows the customer to see how much they will receive

            Console.WriteLine($"\nThe customer wants to withdraw {withdraw_amt:C2}\n" +// The rest of the code displays the bank-note info to the screen for the customer to see
            $"This corresponds to the following:\n" +
            $"-->{(int)bankNote_50} $50 bank note(s)\n" +
            $"-->{(int)bankNote_20} $20 bank note(s)\n" +
            $"-->{(int)bankNote_10} $10 bank note(s)\n" +
            $"-->{(int)bankNote_5} $5 bank note(s)\n" +
            $"-->{(int)bankNote_1} $1 bank note(s)\n");
        }




    }







}