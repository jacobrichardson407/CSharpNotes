using _07_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTest
    {
        [TestMethod]
        public void AddContent_shouldAddContentToDirectory()
        {
            // Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            // Act
            bool addResult = repository.AddContentToDirectory(content);

            // Assert
            Assert.IsTrue(addResult);
        }
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            // Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToDirectory(content);

            // Act
            List<StreamingContent> contents = repo.GetContents();
            bool directoryHasContent = contents.Contains(content);

            // Assert
            Assert.IsTrue(directoryHasContent);


        }

        private StreamingContentRepository _repo;
        private StreamingContent _content;
        private StreamingContent _movie1;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to mkae people explode.", 7.6, MaturityRating.R, GenreType.Thriller);
            _movie1 = new StreamingContent("Shrek", "ogre", 10.0, MaturityRating.PG, GenreType.Adventure);
            _repo.AddContentToDirectory(_content);
            _repo.AddContentToDirectory(_movie1);
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            // Arrange
            // Arrange is done in test initialize
            // Act
            StreamingContent foundContent = _repo.GetContentByTitle("Rubber");
            // Assert
            Assert.AreEqual(_content, foundContent);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContent newContent = new StreamingContent("Rubber","A car tire comes to life with the power to make people explode.", 10, MaturityRating.R, GenreType.Thriller);
            // Act
            bool updateResult = _repo.UpdateExistingContentByTitle("Rubber", newContent);
            // Assert
            Assert.IsTrue(updateResult);
        }
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            // Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");
            // Act
            bool removeResult = _repo.DeleteExistingContent(content);
            // Assert
            Assert.IsTrue(removeResult);
        }

        [TestMethod]
        public void DeleteExistingContentByTitle_ShouldReturnTrue()
        {
            bool deleteTitle = _repo.DeleteByContentTitle("Rubber");
            Assert.IsTrue(deleteTitle);
        }

        [TestMethod]
        public void GetAllMoviesByMaturityRating_ShouldReturnContent()
        {
            List<StreamingContent> foundContent = _repo.GetRatingList(MaturityRating.R);
            bool hasContent = foundContent.Contains(_content);

            Assert.IsTrue(hasContent);
        }

        [TestMethod]
        public void GetAllFamilyFriendlyMovies_ShouldReturnCorrectContent()
        {
            List<StreamingContent> foundContent = _repo.GetFamilyFriendlyMovies();

            bool hasContent = foundContent.Contains(_movie1);
            Assert.IsTrue(hasContent);
        }

            
        }
    }
}
