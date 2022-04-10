using Microsoft.AspNetCore.Mvc;
using WizelineGoBootcampChallenge.Models;
using WizelineGoBootcampChallenge.Services.Movies;

namespace WizelineGoBootcampChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMoviesService _moviesService;

        public MovieController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet("/movies", Name = "GetMovies")]
        public async Task<IEnumerable<Movie>> Get()
        {
            var remoteData = await _moviesService.GetTopRatedAsync();

            if (remoteData?.Results != null)
            {
                return remoteData.Results;
            }

            return new List<Movie>();
        }
    }
}
