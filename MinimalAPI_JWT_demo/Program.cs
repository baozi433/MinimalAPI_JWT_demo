using MinimalAPI_JWT_demo.Models;
using MinimalAPI_JWT_demo.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer(); //supports minimal api
builder.Services.AddSingleton<IMovieService, MovieService>(); // DI implementation
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/create", (Movie movie, IMovieService service) => Create(movie, service));

app.MapGet("/get", (int id, IMovieService service) => Get(id, service));

app.MapGet("/list", (IMovieService service) => List(service));

app.MapPut("/update", (Movie newMovie, IMovieService service) => Update(newMovie, service));

app.MapDelete("/delete", (int id, IMovieService service) => Delete(id, service));

IResult Create(Movie movie, IMovieService service)
{
    var result = service.Create(movie);
    return Results.Ok(result);
}

IResult Get(int id, IMovieService service)
{
    var movie = service.Get(id);
    return (movie is null) ? Results.NotFound("Movie not found") : Results.Ok(movie);
}

IResult List(IMovieService service)
{
    var movies = service.GetAll();
    return Results.Ok(movies);
}

IResult Update(Movie newMovie, IMovieService service)
{
    var updatedMovie = service.Update(newMovie);
    return (updatedMovie is null) ? Results.NotFound("Movie not found") : Results.Ok(updatedMovie);
}

IResult Delete(int id, IMovieService service)
{
    var result = service.Delete(id);
    return result ? Results.Ok(result) : Results.BadRequest("Something went wrong");
}

app.Run();
