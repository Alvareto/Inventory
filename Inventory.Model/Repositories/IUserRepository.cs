using System.Collections.Generic;

namespace Inventory
{
    public partial interface IUserRepository : IRepository<User>
    {
        ICollection<User> GetAll();
        ICollection<User> GetAllActive();
        User GetByKey(int _Id);
    }
}
