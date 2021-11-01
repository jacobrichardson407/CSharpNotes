using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository
    {
        // Repository Pattern

        // Directory, mimics a database
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        // CRUD basic necessities of repository pattern


        // Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // Read
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        // Update
        public bool UpdateExistingContentByTitle(string originalTitle, StreamingContent content)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = content.Title;
                oldContent.Description = content.Description;
                oldContent.StarRating = content.StarRating;
                oldContent.MaturityRating = content.MaturityRating;
                oldContent.TypeOfGenre = content.TypeOfGenre;


                return true;
            }
            else
                return false;
        }

        // Delete
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }

        // Delete By Content Id
        public bool DeleteByContentTitle(string originalTitle)
        {
            StreamingContent content = GetContentByTitle(originalTitle);
            bool deleteContent = DeleteExistingContent(content);
            return deleteContent;
            
        }
        // Get all movies of a certain maturity rating
        public List<StreamingContent> GetRatingList(MaturityRating rating)
        {
            List<StreamingContent> ratingList = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.MaturityRating == rating)
                {
                    ratingList.Add(content);
                }
            }
            return ratingList;
        }
        // Get all family friendly movies

        public List<StreamingContent> GetFamilyFriendlyMovies()
        {
            List<StreamingContent> familyFriendly = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.IsFamilyFriendly == true)
                {
                    familyFriendly.Add(content);
                }
            }
            return familyFriendly;
        }

        // Get all movies within a star rating rang (ex movies with rating 4-7)
        public List<StreamingContent> GetMoviesByStarRating(double minStarRating, double maxStarRating)
        {
            List<StreamingContent> starRatingList = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.StarRating >= minStarRating && content.StarRating <= maxStarRating)
                {
                    starRatingList.Add(content);
                }
            }
            return starRatingList;
        }

    }
}
