using System.Collections.Generic;
using NHibernate;

namespace Inventory
{
    public class CategoryRepository : NHibernateRepository<Category>, ICategoryRepository
    {
        private static CategoryRepository _instance;

        private CategoryRepository(ISession session) : base(session)
        {
        }

        public CategoryRepository()
        {
        }

        //public static CategoryRepository GetInstance()
        //{
        //    //var session = NHibernateSessionProvider.SessionFactory.Op
        //}

        public virtual ICollection<Category> GetAll()
        {
            return session.CreateQuery("from Category").List<Category>();
        }

        public virtual Category GetByKey(int _Id)
        {
            return session.Get<Category>(_Id);
        }

        public static CategoryRepository GetInstance(ISession session)
        {
            return _instance ?? (_instance = new CategoryRepository(session));
        }
    }
}