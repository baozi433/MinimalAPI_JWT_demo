using MinimalAPI_JWT_demo.Models;

namespace MinimalAPI_JWT_demo.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {
            new() { Id = 1, Title = "Top Gun: Maverick", Rating = 8.7,  Description = "After more than 30 years of service as one of the Navy's top aviators, Pete 'Maverick' Mitchell is where he belongs, pushing the envelope as a courageous test pilot and dodging the advancement in rank that would ground him. Training a detachment of graduates for a special assignment, Maverick must confront the ghosts of his past and his deepest fears, culminating in a mission that demands the ultimate sacrifice from those who choose to fly it."},
            new() { Id = 2, Title = "Everything Everywhere All At Once", Rating = 8.5, Description = "When an interdimensional rupture unravels reality, an unlikely hero must channel her newfound powers to fight bizarre and bewildering dangers from the multiverse as the fate of the world hangs in the balance."},
            new() { Id = 3, Title = "Don't Look Up", Rating = 7.2, Description = "Two low-level astronomers must go on a giant media tour to warn mankind of an approaching comet that will destroy planet Earth."},
            new() { Id = 4, Title = "The Batman", Rating = 8.0, Description = "When a sadistic serial killer begins murdering key political figures in Gotham, Batman is forced to investigate the city's hidden corruption and question his family's involvement."},
            new() { Id = 5, Title = "Operation Mincemeat", Rating = 6.7, Description = "During WWII, two intelligence officers use a corpse and false papers to outwit German troops."},
        };
    }
}
