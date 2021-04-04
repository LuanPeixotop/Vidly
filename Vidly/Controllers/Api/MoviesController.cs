using AutoMapper;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetMovies()
        {
            return Ok(_context.Movie.Include(c => c.Genre).ToList().Select(Mapper.Map<Movie, MovieDto>));
        }

        public IHttpActionResult GetMovie(int id)
        {
            var Movie = _context.Movie.SingleOrDefault(c => c.Id == id);

            if (Movie == null)
                NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(Movie));
        }

        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto MovieDto)
        {
            if (!ModelState.IsValid)
                BadRequest();

            var Movie = Mapper.Map<MovieDto, Movie>(MovieDto);
            _context.Movie.Add(Movie);
            _context.SaveChanges();

            MovieDto.Id = Movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + MovieDto.Id), MovieDto);
        }

        [HttpPut]
        public void UpdateMovie(int id, MovieDto MovieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var MovieInDb = _context.Movie.SingleOrDefault(c => c.Id == id);

            if (MovieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(MovieDto, MovieInDb);

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var MovieInDb = _context.Movie.SingleOrDefault(c => c.Id == id);

            if (MovieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movie.Remove(MovieInDb);
            _context.SaveChanges();
        }
    }
}
