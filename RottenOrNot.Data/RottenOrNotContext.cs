namespace RottenOrNot.Data
{
	using RottenOrNot.Data.Contracts;
	using RottenOrNot.Models;
	using System.Data.Entity;

	public class RottenOrNotContext : DbContext, IRottenOrNotContext
	{
		public RottenOrNotContext()
			: base("name=RottenOrNot")
		{
		}

		public IDbSet<User> Users { get; set; }
		public IDbSet<Film> Films { get; set; }
		public IDbSet<Serial> Serials { get; set; }
		public DbContext DbContext => this;
		public new IDbSet<T> Set<T>() where T : class
		{
			return base.Set<T>();
		}
	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}