using System.ComponentModel.DataAnnotations;

namespace IRDbApi.Models
{
	public class MovieModel
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Movie title is required.")]
		public required string Title { get; set; }
		public string? Director { get; set; }
		public int Year { get; set; }
		public string? Genre { get; set; }
		public int Duration { get; set; }
		public double Rating { get; set; }
	}
}
