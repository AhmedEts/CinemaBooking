using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CinemaBooking.Models
{
    public class ActorMovie
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }

    //public class ActorMoviesConfiguration : IEntityTypeConfiguration<ActorMovie>
    //{
    //    public void Configure(EntityTypeBuilder<ActorMovie> builder)
    //    {
    //        builder.HasKey(am => new { am.ActorsId, am.MoviesId });
    //    }
    //}
}
