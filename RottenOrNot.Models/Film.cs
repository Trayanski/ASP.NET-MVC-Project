using System.Collections.Generic;

namespace RottenOrNot.Models
{
	public class Film : BaseShow
	{
		public Film()
		{
			this.Genres = new HashSet<Genres>();
			this.Ratings = new List<int>();
			this.RelatedFilms = new HashSet<Film>();
		}
		
		public virtual ICollection<Film> RelatedFilms { get; set; }
	}
}
