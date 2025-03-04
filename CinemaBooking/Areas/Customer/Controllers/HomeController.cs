using System.Diagnostics;
using CinemaBooking.Models;
using CinemaBooking.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace CinemaBooking.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        IMovieRepository movieRepository;
        ICategoryRepository categoryRepository;
        ICinemaRepository cinemaRepository;
        public HomeController(IMovieRepository movieRepository, ICategoryRepository categoryRepository, ICinemaRepository cinemaRepository)
        {
            this.cinemaRepository = cinemaRepository;
            this.movieRepository = movieRepository;
            this.categoryRepository = categoryRepository;
        }


        public IActionResult Index(string movieName)
        {
            var movies = movieRepository.Get(
              includes: [
                  e=>e.Category
                  ]
              );

            if (movieName != null)
            {
                movies = movieRepository.Get(
                filter: e => e.Name.Contains(movieName)
               , includes: [
                 e=>e.Category
                 ]);
            }
            if (!movies.Any())
            {
                return View("NotFoundPage");
            }

            return View(movies.ToList());
        }

        public IActionResult Details(int movieId)
        {
            var movie = movieRepository.GetDetailsByMovieId(movieId);
            return View(movie);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Category()
        {
            var category = categoryRepository.Get();
            return View(category.ToList());
        }

        public IActionResult AllMovies(Category category)
        {
            var movies = movieRepository.Get(
                filter: e => e.CategoryId == category.Id,
                includes: [
                e=>e.Category,
                ]);
            return View(movies.ToList());
        }

        public IActionResult Cinema()
        {
            var cinemas = cinemaRepository.Get();
            return View(cinemas.ToList());
        }
        public IActionResult AllCinemas(Cinema cinema)
        {
            // var movieFilms = dbContext.movies.Include(e => e.cinema).Include(e=>e.category).Where(e => e.CinemaId == cinema.Id);
            var movies = movieRepository.Get(
                filter: e => e.CinemaId == cinema.Id,
                includes: [
                e=>e.Cinema,
                e=>e.Category,
                ]);
            return View(movies);
        }
    }
}
