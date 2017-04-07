using System.Collections.Generic;

namespace RottenOrNot.Models
{
	public class Serial : BaseShow
	{
		public Serial()
		{
			this.Genres = new HashSet<Genres>();
			this.Ratings = new List<int>();
			this.RelatedSerials = new HashSet<Serial>();
		}
		
		public virtual ICollection<Serial> RelatedSerials { get; set; }
	}
}
