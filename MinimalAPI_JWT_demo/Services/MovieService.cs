using MinimalAPI_JWT_demo.Models;
using MinimalAPI_JWT_demo.Repositories;

namespace MinimalAPI_JWT_demo.Services
{
    public class MovieService : IMovieService
    {
        public Movie Create(Movie movie)
        {
            movie.Id = MovieRepository.Movies.Count + 1;
            MovieRepository.Movies.Add(movie);

            return movie;
        }

        public bool Delete(int id)
        {
            var movie = MovieRepository.Movies.FirstOrDefault(x => x.Id == id);

            if (movie != null)
            {
                MovieRepository.Movies.Remove(movie);
                return true;
            }
            else
                return false;

        }

        public Movie Get(int id)
        {
            var movie = MovieRepository.Movies.FirstOrDefault(x => x.Id == id);

            return (movie is null) ? null : movie;
        }

        public List<Movie> GetAll()
        {
            var movies = MovieRepository.Movies;

            return movies;
        }

        public Movie Update(Movie newMovie)
        {
            var oldMovie = MovieRepository.Movies.FirstOrDefault(x => x.Id == newMovie.Id);

            if (oldMovie != null)
            {
                oldMovie.Title = newMovie.Title;
                oldMovie.Description = newMovie.Description;
                oldMovie.Rating = newMovie.Rating;

                return newMovie;
            }
            else
                return null;
        }
    }
}
