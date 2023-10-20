using System.ComponentModel.DataAnnotations;

namespace IRDbApi.Models
{
	public class MovieModel
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Movie title is required.", AllowEmptyStrings = false)]
		// [RegularExpression(@"\S", ErrorMessage = "Movie title cannot be empty or contain only whitespace.")] // ToDo if AllowEmptyStrings = false dose not work as I think it dose.
		public required string Title { get; set; }
		public string? Director { get; set; }
		public int Year { get; set; } = 0;
		public string? Genre { get; set; }
		public int Duration { get; set; } = 0;
		public decimal Rating { get; set; } = 0;
	}
}
