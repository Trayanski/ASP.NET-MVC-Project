using System.Collections.Generic;

namespace RottenOrNot.Models
{
	public class User
	{
		public User()
		{
			this.PreferedGenres = new HashSet<Genres>();
			this.WatchedFilms = new HashSet<Film>();
			this.WatchLaterFilms = new HashSet<Film>();
			this.WatchedSerials = new HashSet<Serial>();
			this.WatchLaterSerials = new HashSet<Serial>();
		}

		public int Id { get; set; }

		public string Username { get; set; }

		public string Password { get; set; }

		public string Email { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int Age { get; set; }
		
		public virtual ICollection<Genres> PreferedGenres { get; set; }
		
		public virtual ICollection<Film> WatchedFilms { get; set; }
		
		public virtual ICollection<Film> WatchLaterFilms { get; set; }
		
		public virtual ICollection<Serial> WatchedSerials { get; set; }
		
		public virtual ICollection<Serial> WatchLaterSerials { get; set; }
	}
}
