using System.Collections.Generic;

namespace RottenOrNot.Models
{
	public abstract class BaseShow
	{
		public int Id { get; set; }

		public string Title { get; set; }
		
		public ICollection<Genres> Genres { get; set; }

		public float Rating { get; set; }

		public string Storyline { get; set; }
		
		public ICollection<int> Ratings { get; set; }
	}
}
