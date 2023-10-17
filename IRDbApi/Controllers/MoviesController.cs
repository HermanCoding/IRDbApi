using IRDbApi.Models;
using IRDbApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IRDbApi.Controllers
{
	// Specifys the route adress to the controller commands
	[Route("api/[controller]")]
	// Spacifys that the controller is for an API
	[ApiController]
	public class MoviesController : ControllerBase
	{
		private readonly IMoviesRepository _repo;

		public MoviesController(IMoviesRepository repo)
		{
			_repo = repo;
		}
		//[HttpPost]
		[HttpGet]
		public IEnumerable<MovieModel> Get()
		{
			return _repo.GetAllMovies();
		}
		//[HttpPut]
		//[HttpDelete]
	}
}
