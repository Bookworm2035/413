using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceapp
{
    //new class that is public to the Program class
    internal class rollDice
    {   //public array for roll values
        public int[] rollTotals;
        public rollDice( int numberOfRolls)
        {   //array with 13 slots
            rollTotals = new int[13];
            //get random num
            Random random = new Random();
            //initialize die
            int die1 = 0;
            int die2 = 0;
            int total = 0;
            //for each roll generate values
            for (int i = 0; i < numberOfRolls; i++)
            {
                // Generate a random number between 1 and 6 (inclusive)
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                total = die1 + die2;
                //store to array
                rollTotals[total]++;
            }
        }
    }
}


