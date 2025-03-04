using CinemaBooking.Data;
using CinemaBooking.Models;
using CinemaBooking.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace CinemaBooking.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        private readonly ApplicationDbContext dbContext;

        public MovieRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public Movie? GetDetailsByMovieId(int Id)
        {
            return dbContext.movies
                          .Include(e => e.Cinema)
                          .Include(e => e.Category)
                          .Include(e => e.ActorMovies)
                          .ThenInclude(e => e.Actor)
                          .FirstOrDefault(e => e.Id == Id);
        }
    }
}
