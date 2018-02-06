using System.Collections.Generic;
using FluentNHibernate.Cfg;
using Inventory.SQLiteDAL;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace Inventory.Tests
{
    public static class NHibernateTestConfiguration
    {
        private const string CONN_STR = "Data Source=:memory:;Version=3;New=false;";
        private static Configuration _configuration;
        private static ISessionFactory _sessionFactory;

        public static Configuration Configuration
        {
            get
            {
                if (_configuration == null)
                    _configuration = new Configuration()
                        .AddProperties(new Dictionary<string, string>
                        {
                            {Environment.ConnectionDriver, typeof(SQLite20Driver).FullName},
                            {Environment.Dialect, typeof(SQLiteDialect).FullName},
                            {Environment.ConnectionProvider, typeof(DriverConnectionProvider).FullName},
                            {Environment.ConnectionString, CONN_STR},
                            {Environment.ShowSql, true.ToString()},
                            {Environment.CurrentSessionContextClass, "thread_static"}
                        });

                return _configuration;
            }
        }

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var nhConfig = Fluently.Configure(_configuration);
                    nhConfig.Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateSessionProvider>())
                        //.ExposeConfiguration(x => x.EventListeners.PreInsertEventListeners = new IPreInsertEventListener[] { new AuditEventListener() })
                        //.ExposeConfiguration(x => x.EventListeners.PreUpdateEventListeners = new IPreUpdateEventListener[] { new AuditEventListener() })
                        .BuildConfiguration();

                    _sessionFactory = nhConfig.BuildSessionFactory();
                }

                return _sessionFactory;
            }
        }
    }
}