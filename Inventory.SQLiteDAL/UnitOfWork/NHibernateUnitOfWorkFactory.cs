using System;
using Inventory.SQLiteDAL;
using NHibernate;

namespace Inventory
{
    public partial class NHibernateUnitOfWorkFactory : IUnitOfWorkFactory
    {
        protected ISession _session = null;

        public NHibernateUnitOfWorkFactory()
            : this(NHibernateSessionProvider.SessionFactory.OpenSession())
        {
        }
        
        public NHibernateUnitOfWorkFactory(ISession session)
        {
            if (session == null)
            {
                throw new ArgumentNullException("session");
            }
            _session = session;
        }

        #region IUnitOfWorkFactory Members

        public virtual IUnitOfWork Create()
        {
            if (_session == null)
                throw new InvalidOperationException("Session has not been initialized.");
            return new NHibernateUnitOfWork(_session);
        }
        #endregion
    }
}
