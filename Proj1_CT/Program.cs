using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_CT
{
    class Program
    {


        static void Main(string[] args)
        {//PART1:
            Console.WriteLine("Welcome!!!\n\n\n                 Please take this questionare");

            //Ask user first name?
            Console.WriteLine("\n\n\nWhat is your first name?");
            string name = Console.ReadLine();

            //Ask user last name?
            Console.WriteLine("What is your last name?");
            string name2 = Console.ReadLine();

            //What is user age?
            Console.WriteLine("How old are you?");
            Console.ReadLine();
            int i;

            //Ask user for birth month (as 'int')
            Console.WriteLine("What is the number of your birth month?");
            int M = int.Parse(Console.ReadLine());

            if (M == 1 - 4) ;
                {
                Console.WriteLine("You will have $250,000 in the bank");
            }     
            
                   
            //If age ODD-Retire 4-8yrs; If EVEN-Retire in 2-4 years

            int i;
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write(" Congrats! You will retire in 2-4 years");
                Console.Read();
            }
            else
            {
                Console.Write("Sorry you will retire in 4-8 years");
                Console.Read();

            }
            //Ask the user for number of siblings
            Console.WriteLine("How many siblings do you have?");
            string name3 = Console.ReadLine();

            //If user # of siblings 0 then they will have a vacay home in DC| #2 vacay home in Cape Town| #3 vacay home in Dubai| if user enters in anything than a # >=0| Bad vacay home
            int a;
            int b;
            int c;
            int d;
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.Read(); Console.Write("You don't actually need a break, you will have a vacation home in DC."); }
            b = int.Parse(Console.ReadLine());
            if (b == 2)
            
                Console.Write("A break is needed, you will have a vacation home in Cape Town.");
                c = int.Parse(Console.ReadLine());
                if (c <= 3)
              
            Console.Write("I feel your pain, you will have a vacation home in Dubai, have fun!.");
            d = int.Parse(Console.ReadLine());
        
            if (d < 0)
                Console.Write("Sorry, your will have a vacation home in Afganistan.");
        
                /***********///Ask for user's favorite ROYGBIV color| If user doesn't know what it is, ask them to enter "HELP"

                Console.WriteLine("What is your favorite ROYGBIV color?" + "Type HELP if unknown");
                string rvColor = Console.ReadLine();
                Console.WriteLine("ROYGBIV stands for: Red, Orange, Yellow, Green, Blue, Indigo and Violet");
                Console.WriteLine("Please enter number 1-10 in word form");
                //string number = Console.ReadLine();




            




        



            
            
         }
    }
}
