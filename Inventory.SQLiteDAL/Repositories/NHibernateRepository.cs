using System;
using Inventory.SQLiteDAL;
using NHibernate;

namespace Inventory
{
    public class NHibernateRepository<T> : IRepository<T>
    {
        protected ISession session;

        public NHibernateRepository() : this(NHibernateSessionProvider.SessionFactory.OpenSession())
        {
        }

        public NHibernateRepository(ISession session)
        {
            if (session == null)
                throw new ArgumentNullException("session");
            this.session = session;
        }

        //public static NHibernateRepository<T> GetInstance()
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new NHibernateRepository<T>(NHibernateSessionProvider.GetSession());
        //    }
        //    return _instance;
        //}

        //public static NHibernateRepository<T> GetInstance(ISession context)
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new NHibernateRepository<T>(context);
        //    }
        //    return _instance;
        //}

        public virtual void Add(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            if (!session.Transaction.IsActive)
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(entity);
                    transaction.Commit();
                }
            else
                session.Save(entity);
        }

        public virtual void Remove(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            if (!session.Transaction.IsActive)
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(entity);
                    transaction.Commit();
                }
            else
                session.Delete(entity);
        }
    }
}