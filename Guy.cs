using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JoeAndBob
{
    internal class Guy
    {
        public string Name;
        public int Cash;
        /// <summary>
        /// Writes my name and the amount of cash I have to the console. 
        /// </summary>
        public void WriteMyInfo()
        {
            WriteLine(Name + " has " + Cash + " dollars.");
        }
        /// <summary>
        /// Gives some of my cash, removing it from my wallet (or printing a msg to the console if i don't have enough). 
        /// </summary>
        /// <param name="amount">Amount of Cash to give.</param>
        /// <returns>
        /// The amount of cash removed from my wallet or 0 if i don't have enough cash (or if amount is invalid).
        /// </returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                WriteLine(Name + " says: " + amount + " isn't a valid amount. ");
                return 0;
            }
            if (amount > Cash)
            {
                WriteLine(Name + " says: " + " I don't have enough to give " + amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }
        /// <summary>
        /// Receive some cash, adding it to my wallet (or printing a message to the console if the amount is invalid).
        /// </summary>
        /// <param name="amount">Amount of Cash to give.</param>
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                WriteLine(Name + " says: " + amount + " isn't an amount i'll take. ");
            }
            else { Cash += amount; }
        }
    }
}
