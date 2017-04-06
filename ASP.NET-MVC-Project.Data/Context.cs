namespace ASP.NET_MVC_Project.Data
{
	using System.Data.Entity;

	public class Context : DbContext
	{
		public Context()
			: base("name=ExamProjectDatabase")
		{
		}

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}