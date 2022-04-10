using WizelineGoBootcampChallenge.Models;

namespace WizelineGoBootcampChallenge.Services.Movies
{
    public interface IMoviesService
    {
        Task<SearchResponse<Movie>> GetTopRatedAsync();
    }
}
