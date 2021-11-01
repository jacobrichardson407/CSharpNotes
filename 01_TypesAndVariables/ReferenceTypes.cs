using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string thisIsDeclared;

            thisIsDeclared = "This is initialized";

            string firstName = "Luke";
            string lastName = "Skywalker";

            // Concatenation
            string concatenatedString = firstName + " " + lastName;
            // Output = "Luke Skywalker"

            // Composite Formatting
            string compositeString = string.Format("{0} {1}", firstName, lastName);
            // Output = "Luke Skywalker"
            string compositeString2 = string.Format("{0} is a Jedi, his lineage is {1}", firstName, lastName);
            // Output = "Luke is a Jedi, his lineage is Skywalker"

            // Interpolation
            string interpolatedString = $"{firstName} {lastName}";
            // Output = "Luke Skywalker"
        }

        [TestMethod]
        public void Collections()
        {
            // A collection of char types
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World", "More", "Words", "Here" };

            // Zero based indexing
            //                          0        1          2
            string[] pastryArray = { "Cake", "Cupcake", "Eclair" };

            // Accessing a value from an arrey index
            string cupcake = pastryArray[1];

            // Assigning a value again at an index
            stringArray[1] = "world";
            // Array has size defined at intialization

            // Lists are like arrays, can be added/removed after initialization
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("string");
            listOfStrings.Add("323454");

            // Queues
            // First In First Out

            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm next");

            // Dictionary
            // Uses a key-value pair

            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(3, "Throw");

            string throwExample = keyAndValue(3);

            Dictionary<string, string> webster = new Dictionary<string, string>();
            webster.Add("Garden", "A place to grow plants");

            string gardenDefinition = webster["Garden"];

            // Other Collections

            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> LastInFirstOut = new Stack<string>();

        }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next();
        }
    }
}
