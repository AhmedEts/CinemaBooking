using CinemaBooking.Models;

namespace CinemaBooking.Repositories.IRepositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        public Movie? GetDetailsByMovieId(int movieId);

    }
}
