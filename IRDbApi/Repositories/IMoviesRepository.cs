using IRDbApi.Models;

namespace IRDbApi.Repositories
{
	public interface IMoviesRepository
	{
		public IEnumerable<MovieModel> GetAllMovies();

		public void PostMovie(MovieModel movie);

		public MovieModel GetMovieById(int id);
		public MovieModel GetMovieByName(string title);

		public void UpdateMovie(int id, MovieModel movie);

		public void DeleteMovieById(int id);
		public void DeleteMovieByName(string title);
	}
}
