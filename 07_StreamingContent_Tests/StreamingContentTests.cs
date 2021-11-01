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
            // Arrange
            StreamingContent content = new StreamingContent();

            content.Title = "Toy Story";

            // Act
            string expected = "Toy Story";
            string actual = content.Title;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // Test IsFamilyFriendly
        [DataTestMethod]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.TV_G, true)]
        [DataRow(MaturityRating.R, false)]
        [DataRow(MaturityRating.TV_MA, false)]

        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendlyRating(MaturityRating maturity, bool expectedFamilyFriendly)
        {
            // Triple A paradigm

            // Arrange => set stage for testing
            StreamingContent content = new StreamingContent("Some Title", "Some Description", 3.5, maturity, GenreType.Horror);
            // Act => execute code we run
            bool actual = content.IsFamilyFriendly;
            bool expected = expectedFamilyFriendly;
            // Assert => call our assertions
            Assert.AreEqual(actual, expected);
        }
    }
}
