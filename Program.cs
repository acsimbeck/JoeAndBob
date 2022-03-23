using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace JoeAndBob
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Create a new Guy obj in a variable called joe
             * Set its Name field to "Joe"
             * Set its Cash field to 50
             */
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            /* Create a new Guy obj in a variable called joe
             * Set its Name field to "Bob"
             * Set its Cash field to 100
             */
            Guy bob = new Guy() { Cash = 100, Name = "Bob" };

            while (true)
            {
                // Call the WriteMyInfo methods for each Guy obj
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                WriteLine("Enter an amount: ");
                string howMuch = ReadLine();
                if (howMuch == "") return;
                /* Use int.TryParse to try to convert the howMuch string to an int 
                 * If successful...*/
                if(int.TryParse(howMuch, out int amount))
                {
                    WriteLine("Who should give the cash: ");
                    string whichGuy = ReadLine();   
                    if (whichGuy == "Joe")
                    {
                        // Call the joe obj GiveCash method and save the results 
                        int cashGiven = joe.GiveCash(amount);

                        // Call the bob obj ReceiveCash method with the saved results 
                        bob.ReceiveCash(cashGiven);

                    }
                    else if (whichGuy == "Bob")
                    {
                        // Call the bob obj GiveCash method and save the results 
                        int cashGiven = bob.GiveCash(amount);
                        // Call the joe obj ReceiveCash method with the saved results */
                        joe.ReceiveCash(cashGiven);
                        
                    }
                    else { WriteLine("Please enter 'Joe' or 'Bob' "); }
                }
                else { WriteLine("Please enter an amount (or a blank line to exit). "); }
            }
        }
    }
}