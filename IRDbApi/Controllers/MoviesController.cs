using IRDbApi.Models;
using IRDbApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IRDbApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MoviesController : ControllerBase
	{
		private readonly IMoviesRepository _repo;

		public MoviesController(IMoviesRepository repo)
		{
			_repo = repo;
		}
		// Add a new movie to the database
		// TODO Fixa så att id uppdateras utan att man väljer id eller 0
		[HttpPost]
		public void Post([FromForm] MovieModel movieToAdd)
		{
			_repo.PostMovie(movieToAdd);
		}
		
		// Get all Movies
		[HttpGet]
		public IEnumerable<MovieModel> Get()
		{
			return _repo.GetAllMovies();
		}

		//Get Movie by Id
		[HttpGet("{id}")]
		public ActionResult Get(int id)
		{
			MovieModel movie = _repo.GetMovieById(id);
			if (movie != null)
			{
				return Ok(movie);
			}
			return NotFound($"Movie with ID {id} not found.");
		}

		// Update movie in db
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] MovieModel movieToUpdate) 
		{ 
			_repo.UpdateMovie(id, movieToUpdate);
		}

		// Delete movie from db
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_repo.DeleteMovieById(id);
		}

	}
}
