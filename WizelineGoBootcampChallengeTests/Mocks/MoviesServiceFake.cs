using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizelineGoBootcampChallenge.Models;
using WizelineGoBootcampChallenge.Services.Movies;

namespace WizelineGoBootcampChallengeTests.Mocks
{
    internal class MoviesServiceFake : IMoviesService
    {
        private readonly SearchResponse<Movie> _response;
        private readonly List<Movie> _movies;

        public MoviesServiceFake()
        {
            _movies = new List<Movie>() { 
                new Movie()
                {
                    Id = 278,
                    Title= "The Shawshank Redemption",
                    IsAdultThemed = false,
                    BackdropPath = "/wPU78OPN4BYEgWYdXyg0phMee64.jpg",
                    Budget = 0,
                    Homepage = null,
                    ImdbId = null,
                    OriginalLanguage = "en",
                    OriginalTitle = "The Shawshank Redemption",
                    Overview = "Framed in the 1940s for the double murder of his wife and her lover, upstanding banker Andy Dufresne begins a new life at the Shawshank prison, where he puts his accounting skills to work for an amoral warden. During his long stretch in prison, Dufresne comes to be admired by the other inmates -- including an older prisoner named Red -- for his integrity and unquenchable sense of hope.",
                    Popularity = 92.41,
                    PosterPath = "/q6y0Go1tsGEsmtFryDOJo3dEmqu.jpg",
                    ReleaseDate = DateTime.Now,
                    Revenue = 0,
                    Status = null,
                    Tagline = null,
                    IsVideo = false,
                    VoteAverage = 8.7,
                    VoteCount = 21136
                },
                new Movie()
                {
                    Id = 19404,
                    Title = "Dilwale Dulhania Le Jayenge",
                    IsAdultThemed = false,
                    BackdropPath = "/90ez6ArvpO8bvpyIngBuwXOqJm5.jpg",
                    Budget = 0,
                    Homepage = null,
                    ImdbId = null,
                    OriginalLanguage = "hi",
                    OriginalTitle = "दिलवाले दुल्हनिया ले जायेंगे",
                    Overview = "Raj is a rich, carefree, happy-go-lucky second generation NRI. Simran is the daughter of Chaudhary Baldev Singh, who in spite of being an NRI is very strict about adherence to Indian values. Simran has left for India to be married to her childhood fiancé. Raj leaves for India with a mission at his hands, to claim his lady love under the noses of her whole family. Thus begins a saga.",
                    Popularity = 23.766,
                    PosterPath = "/2CAL2433ZeIihfX1Hb2139CX0pW.jpg",
                    ReleaseDate = DateTime.Now,
                    Revenue = 0,
                    Status = null,
                    Tagline = null,
                    IsVideo = false,
                    VoteAverage = 8.7,
                    VoteCount = 3557
                }
            };

            _response = new SearchResponse<Movie> 
            {
                Results = _movies,
                PageNumber = 1,
                TotalPages = 10,
                TotalResults = 2,
            };
        }

        public Task<SearchResponse<Movie>> GetTopRatedAsync()
        {
            return Task.FromResult(_response);
        }
    }
}
