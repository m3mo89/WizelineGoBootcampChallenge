namespace WizelineGoBootcampChallenge.Services.Request
{
    public interface IRequestService
    {
        Task<TResult> GetAsync<TResult>(string uri);
    }
}
