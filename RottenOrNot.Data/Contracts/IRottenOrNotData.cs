using RottenOrNot.Data.Repositories;
using RottenOrNot.Models;

namespace RottenOrNot.Data.Contracts
{
    public interface IRottenOrNotData
    {
        Repository<User> Users { get; }

        Repository<Film> Films { get; }

        Repository<Serial> Serials { get; }

        IRottenOrNotContext Context { get; }

        int SaveChanges();
    }
}
