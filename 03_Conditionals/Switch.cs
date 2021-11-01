using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is a default statement.");
                    break;
            }

            string age = 37;

            switch (age)
            {
                case "18":
                    // code for 18
                    break;
                case "32":
                    // code for 32
                    break;
                case "33":
                    // code for 33
                    break;
                case "34":
                case "35":
                default:
                    break;
                    // Inefficient for ranges or vague conditions
            }
        }
    }
}
