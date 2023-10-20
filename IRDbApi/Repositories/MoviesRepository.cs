using IRDbApi.Database;
using IRDbApi.Models;
using System.Net;

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
			MovieModel movieToDelete = _context.Movies.FirstOrDefault(m => m.Id == id);
			if (movieToDelete != null)
			{
				_context.Movies.Remove(movieToDelete);
				_context.SaveChanges();
			}
		}

		public IEnumerable<MovieModel> GetAllMovies()
		{
			return _context.Movies;
		}

		public MovieModel GetMovieById(int id)
		{
			return _context.Movies.FirstOrDefault(m => m.Id == id);
		}

		public MovieModel GetMovieByName(string title)
		{
			throw new NotImplementedException();
		}

		public void PostMovie(MovieModel movie)
		{
			_context.Movies.Add(movie);
			_context.SaveChanges();
		}

		public void UpdateMovie(int id, MovieModel movie)
		{
			MovieModel movieToUpdate = _context.Movies.FirstOrDefault(m =>m.Id == id);

            if (movieToUpdate != null)
			{
				movieToUpdate.Title = movie.Title;
				movieToUpdate.Director = movie.Director;
				movieToUpdate.Year = movie.Year;
				movieToUpdate.Genre = movie.Genre;
				movieToUpdate.Duration = movie.Duration;
				movieToUpdate.Rating = movie.Rating;
				_context.SaveChanges();
			}
        }
	}
}
