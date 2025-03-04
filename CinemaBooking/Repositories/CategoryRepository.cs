using CinemaBooking.Data;
using CinemaBooking.Models;
using CinemaBooking.Repositories.IRepositories;

namespace CinemaBooking.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;

        }
    }
}
