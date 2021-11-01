﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;

            if (userIsHungry)
            {
                Console.WriteLine("Eat something!");
            }

            int age = 15;

            if (age < 18)
            {
                Console.WriteLine("You're not legally an adult yet.");
            }


        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;

            if (choresAreDone)
            {
                Console.WriteLine("Have fun at the movies!");
            }

            else
            {
                Console.WriteLine("You must stay home and finish your chores!");
            }

            string input = "3";
            int totalhours = int.Parse(input);

            if (totalhours >= 8)
            {
                Console.WriteLine("You should be well rested!");
            }
            else
            {
                Console.WriteLine("You must be tired today!");
                if (totalhours < 4)
                {
                    Console.WriteLine("You should get more sleep!");
                }
            }

            if (totalhours > 8)
                Console.WriteLine("Wow that's a lot of studying!");
            else Console.WriteLine("You should study more!");
        }

        [TestMethod]
        public void IfElseIfStatements()
        {
            int age = 55;

            if (age > 17)
            {
                Console.WriteLine("You're an adult!");
            }
            else
            {
                if (age > 6)
                {
                    Console.WriteLine("You're a kid!");
                }
                else if (age > 0)
                {
                    Console.WriteLine("You're too young to use a computer!");
                }
                else
                {
                    Console.WriteLine("You're not even born yet!");
                }
            }

            if (age >= 55)
            {
                Console.WriteLine("senior discount time!");
            }
            else if (age > 21 && age < 55)
            {
                Console.WriteLine("Age is between 21 and 55.");
            }
            else if (age <= 19)
            {
                Console.WriteLine("You're either a teenager or will be soon!");
            }
            else
            {
                Console.WriteLine("You must be 20.");
            }





        }
    }
}
