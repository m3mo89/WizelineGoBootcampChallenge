using WizelineGoBootcampChallenge.Models;
using WizelineGoBootcampChallenge.Services.Request;

namespace WizelineGoBootcampChallenge.Services.Movies
{
    public class MoviesService : IMoviesService
    {
        private readonly ILogger<MoviesService> _logger;
        private readonly IConfiguration _configuration;
        private readonly IRequestService _requestService;

        public MoviesService(ILogger<MoviesService> logger, IConfiguration configuration, IRequestService requestService)
        {
            _logger = logger;
            _configuration = configuration;
            _requestService = requestService; 
        }

        public async Task<SearchResponse<Movie>> GetTopRatedAsync()
        {
            try
            {
                string uri = $"{_configuration["Api:Url"]}movie/top_rated?api_key={_configuration["Api:Key"]}&language=en&page=1";

                SearchResponse<Movie> response = await _requestService.GetAsync<SearchResponse<Movie>>(uri);

                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message, ex.Data);
                return new SearchResponse<Movie>();
            }
        }
    }
}
