﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your favorite color in English with lower case letter");
            var color = Console.ReadLine();
            if(color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Your color is red!");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor= ConsoleColor.Cyan;
                Console.ForegroundColor= ConsoleColor.Black;
                Console.WriteLine("Your color is cyan!");
            }
            Console.ReadKey();   

        }
    }
}
