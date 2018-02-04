using System;
using System.Windows.Forms;
using Inventory.Core;
using Inventory.SQLiteDAL;
using NHibernate;

namespace Inventory.Forms
{
    public class SessionForm : Form, IPresenterSessionManagemet, IDisposable
    {
        private ISession session = null;
        private IStatelessSession statelessSession = null;

        public ISession Session
        {
            get
            {
                if (session == null)
                    session = NHibernateSessionProvider.SessionFactory.OpenSession();
                return session;
            }
        }

        public IStatelessSession StatelessSession
        {
            get
            {
                if (statelessSession == null)
                    statelessSession = NHibernateSessionProvider.SessionFactory.OpenStatelessSession();
                return statelessSession;
            }
        }

        public new void Dispose()
        {
            base.Dispose();
            if (session != null)
                session.Dispose();
            if (statelessSession != null)
                statelessSession.Dispose();
        }
    }
}