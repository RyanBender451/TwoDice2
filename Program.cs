using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDiceRoller
{
    //This is just a simple program to start off the dice game program.  More of a testing run for some basic functions

    class Program
    {
        static void Main(string[] args)
        {
            Random d1 = new Random();
            Random d2 = new Random();
            int dice1 = d1.Next(1,7);
            int dice2 = d1.Next(1,7);


            Console.WriteLine("Dice 1: " + dice1);
            Console.WriteLine("Dice 2: " + dice2);

            
        }
    }
}
