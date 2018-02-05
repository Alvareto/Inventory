using System.Collections.Generic;
using Inventory.SQLiteDAL;
using NHibernate;
using NHibernate.Linq;

namespace Inventory
{
    public partial class CategoryRepository : NHibernateRepository<Category>, ICategoryRepository
    {
        private static CategoryRepository _instance;

        private CategoryRepository(ISession session) : base(session)
        {
        }

        public static CategoryRepository GetInstance(ISession session)
        {
            return _instance ?? (_instance = new CategoryRepository(session));
        }

        //public static CategoryRepository GetInstance()
        //{
        //    //var session = NHibernateSessionProvider.SessionFactory.Op
        //}

        public virtual ICollection<Category> GetAll()
        {
            return session.CreateQuery(string.Format("from Category")).List<Category>();
        }

        public virtual Category GetByKey(int _Id)
        {
            return session.Get<Category>(_Id);
        }
    }
}