using CinemaBooking.Data;
using CinemaBooking.Models;
using CinemaBooking.Repositories.IRepositories;

namespace CinemaBooking.Repositories
{
    public class ActorMovieRepository : Repository<ActorMovie>, IActorMovieRepository
    {
        public ActorMovieRepository(ApplicationDbContext applicationDb) : base(applicationDb)
        {
        }
    }
}
