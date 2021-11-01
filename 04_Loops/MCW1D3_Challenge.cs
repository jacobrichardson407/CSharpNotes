using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class MCW1D3_Challenge
    {
        private string super;

        [TestInitialize]
        public void Init()
        {
            super = "Supercalifragilisticexpialidocious";
        }


        [TestMethod]
        public void W1D3_ConditionalsAndLoopsChallenge_1()
        {
            foreach (char letter in super)
            {
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void W1D3_ConditionalsAndLoopsChallenge_2_WithLetter_L_Check()
        {
            foreach (char letter in super)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else if (letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine($"Not an I or an L : {letter}");
                }
            }
        }

        [TestMethod]
        public void W1D3_ConditionalsAndLoopsChallenge_2_WithLetter_L_Check_Or()
        {
            foreach (char letter in super)
            {
                if (letter == 'i' || letter == 'l')
                {
                    Console.WriteLine($"Not and I or L : {letter}");
                }
            }
        }

        [TestMethod]
        public void W1D3_ConditionalsAndLoopsChallenge_2_WithLetter_L_Check_Switch()
        {
            foreach (char letter in super)
            {
                switch (letter)
                {
                    case 'i':
                        Console.WriteLine(letter);
                        break;
                    case 'l':
                        Console.WriteLine(letter);
                        break;
                    default:
                        Console.WriteLine($"Not an i or l: {letter}");
                        break;
                }
            }
        }

        [TestMethod]
        public void W1D3_ConditionalsAndLoopsChallenge_2_Bonus()
        {
            Console.WriteLine("Using a while loop:");
            // initialize a counter
            int count = 1;
            while (count < super.Length)
            {
                // this counts up one per character
                count++;
            }
            Console.WriteLine("Total Count: " + count);
            Console.WriteLine("Actual Count: " + super.Length);
        }
    }
}
