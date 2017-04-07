using System.Data.Entity;
using RottenOrNot.Models;

namespace RottenOrNot.Data.Contracts
{
    public interface IRottenOrNotContext
    {
        IDbSet<User> Users { get; }

        IDbSet<Film> Films { get; }
               
        IDbSet<Serial> Serials { get; }

        DbContext DbContext { get; }

        int SaveChanges();
        IDbSet<T> Set<T>()
           where T : class;

    }
}
