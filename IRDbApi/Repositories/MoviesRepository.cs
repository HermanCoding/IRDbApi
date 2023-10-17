using IRDbApi.Database;
using IRDbApi.Models;

namespace IRDbApi.Repositories
{
	public class MoviesRepository : IMoviesRepository
	{
		private readonly AppDbContext _context;
		public MoviesRepository(AppDbContext context) 
		{ 
			_context = context;
		}

		public void DeleteMovieById(int id)
		{
			throw new NotImplementedException();
		}

		public void DeleteMovieByName(string title)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<MovieModel> GetAllMovies()
		{
			return _context.Movies;
		}

		public MovieModel GetMovieById(int id)
		{
			throw new NotImplementedException();
		}

		public MovieModel GetMovieByName(string title)
		{
			throw new NotImplementedException();
		}

		public void PostMovie(MovieModel movie)
		{
			throw new NotImplementedException();
		}

		public void UpdateMovie(int id, MovieModel movie)
		{
			throw new NotImplementedException();
		}
	}
}
