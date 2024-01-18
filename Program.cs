using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using diceapp;
public class Program
{//built in class that is automaticaly there hehe
    private static void Main()
    {
        //this class gets the number of rolls and then prints the histogram using an array from second class
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
        //get the user imput 
        int numberOfRolls = int.Parse(Console.ReadLine());
        //call rollDice class and create a new instance
        rollDice rd = new rollDice(numberOfRolls);
        //get values from other class
        int[] rollTotals = rd.rollTotals;

        //labels for the histogram
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine($"Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

        //for loop to cycle through each die value
        for (int i = 2; i < rollTotals.Length; i++)
        {
            //int Percentage =  rollTotals[i] / numberOfRolls * 100;
            double Percentage = ((double)rollTotals[i] / numberOfRolls) * 100;
            //Percentage = num of rolls for each number  DIVIDED BY TOTAL ROLLS *100;
            string result = new string('*', (int)(Percentage));
            //write out the ***
            Console.Write(($"{i} : {result} \n"));
        }
    }
}



