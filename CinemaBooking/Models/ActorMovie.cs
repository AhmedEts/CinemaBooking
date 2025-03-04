using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CinemaBooking.Models
{
    public class ActorMovie
    {
        public int ActorsId { get; set; }
        public int MoviesId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
        public string Role { get; set; }
    }

    public class ActorMoviesConfiguration : IEntityTypeConfiguration<ActorMovie>
    {
        public void Configure(EntityTypeBuilder<ActorMovie> builder)
        {
            builder.HasKey(am => new { am.ActorsId, am.MoviesId });
        }
    }
}
