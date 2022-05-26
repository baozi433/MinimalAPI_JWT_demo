using MinimalAPI_JWT_demo.Models;

namespace MinimalAPI_JWT_demo.Services
{
    public interface IMovieService
    {
        public Movie Create(Movie movie);
        public Movie Update(Movie movie);
        public bool Delete(int id);
        public Movie Get(int id);
        public List<Movie> GetAll();
    }
}
