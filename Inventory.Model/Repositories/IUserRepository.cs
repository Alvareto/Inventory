using System.Collections.Generic;

namespace Inventory
{
    public interface IUserRepository : IRepository<User>
    {
        ICollection<User> GetAll();
        ICollection<User> GetAllActive();
        User GetByKey(int _Id);
    }
}