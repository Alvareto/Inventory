using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Controllers
{
    public class Controller
    {
        private IUnitOfWorkFactory uowFactory;
        private IUserRepository repository;

        public Controller()
        {
            var context = NHibernateSessionProvider.GetSession();
            this.uowFactory = new NHibernateUnitOfWorkFactory(context);
            this.repository = new UserRepository(context);//new NHibernateRepository<User>(context);
        }

        //public Controller(IUnitOfWorkFactory uowFactory, IRepository<User> repository)
        //{
        //    this.uowFactory = uowFactory;
        //    this.repository = repository;
        //}

        public ICollection<User> GetUsers()
        {
            return repository.GetAll();
        }

    }
}
