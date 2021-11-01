using _07_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        // Basic Functionality test (make sure the class works)
        [TestMethod]
        public void SetTitle_ShouldGetCorrectString()
        {
            StreamingContent content = new StreamingContent();

            content.Title = "Toy Story";

            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }
        // Test Family Friendly
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
