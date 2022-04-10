using WizelineGoBootcampChallenge.Services.Movies;
using WizelineGoBootcampChallenge.Services.Request;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IRequestService, RequestService>();
builder.Services.AddScoped<IMoviesService, MoviesService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/helloWorld", () => "Hello World!")
.WithName("GetHelloWorld");

app.MapGet("/movies", async (IMoviesService moviesService) =>
{
    var remoteData = await moviesService.GetTopRatedAsync();

    return remoteData.Results;
})
.WithName("GetMovies");

app.Run();