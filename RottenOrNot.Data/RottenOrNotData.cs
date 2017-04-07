using RottenOrNot.Data.Contracts;
using RottenOrNot.Data.Repositories;
using RottenOrNot.Models;

namespace RottenOrNot.Data
{
    public class RottenOrNotData : IRottenOrNotData
    {
        private readonly IRottenOrNotContext context;

        public RottenOrNotData()
            :this(new RottenOrNotContext())
        {
        }

        public RottenOrNotData(IRottenOrNotContext context)
        {
            this.context = context;
        }

        public Repository<User> Users =>  new Repository<User>(this.context);
        
        public Repository<Film> Films => new Repository<Film>(this.context);

        public Repository<Serial> Serials => new Repository<Serial>(this.context);

        public IRottenOrNotContext Context => this.context;

        public int SaveChanges()
        {
            return this.Context.DbContext.SaveChanges();
        }
    }
}
