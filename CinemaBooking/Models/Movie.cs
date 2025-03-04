using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CinemaBooking.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        [ValidateNever]

        public DateTime StartDate { get; set; }
        [Required]

        public DateTime EndDate { get; set; }
        [ValidateNever]

        public string ImgUrl { get; set; }
        public string TrailerUrl { get; set; }
        [Required]

        public MovieStatus MovieStatus { get; set; }
        public int CinemaId { get; set; }
        [ValidateNever]

        public Cinema Cinema { get; set; }
        [ValidateNever]

        public int CategoryId { get; set; }
        [ValidateNever]

        public Category Category { get; set; }
        [ValidateNever]

        //public List<Actor> Actors { get; set; }
        //[Required]
        //[ValidateNever]
        //public List<ActorMovies> ActorMovies { get; set; }

        public ICollection<ActorMovie> ActorMovies { get; set; }


    }
}
