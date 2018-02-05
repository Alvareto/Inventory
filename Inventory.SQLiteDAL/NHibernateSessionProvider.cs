using System.Data;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;

namespace Inventory.SQLiteDAL
{
    public class NHibernateSessionProvider
    {

        private static Configuration configuration;
        private static ISessionFactory sessionFactory;
        private static string _connectionString = "Data Source=|DataDirectory|/Inventory.db;Version=3";
        private static string _fileName = @"Inventory.db";

        private NHibernateSessionProvider()
        {
        }

        public static Configuration Configuration
        {
            get
            {
                if (configuration == null)
                {
                    configuration = new Configuration(); // 
                    configuration.SetProperty(NHibernate.Cfg.Environment.ConnectionString, _connectionString);

                    configuration = Fluently.Configure()
                        .Database(SQLiteConfiguration.Standard
                            .ShowSql()
                            .FormatSql()
                            .ConnectionString(_connectionString) //.UsingFile(_fileName)
                                                                 //.AdoNetBatchSize(100)
                            .IsolationLevel(IsolationLevel.ReadCommitted)
                            .MaxFetchDepth(4)
                        )
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateSessionProvider>())
                        .CurrentSessionContext(typeof(ThreadStaticSessionContext).FullName)
                        .BuildConfiguration();
                }

                return configuration;
            }
        }

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    var schemaExport = new SchemaExport(Configuration);
                    schemaExport.Create(false, true);

                    //sessionFactory = FluentNHibernate.Cfg.Fluently.Configure(Configuration).Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateSessionProvider>()).BuildSessionFactory();
                    sessionFactory = Configuration.
                        BuildSessionFactory();
                }
                return sessionFactory;
            }
        }

        public static ISession GetSession()
        {

            return SessionFactory.OpenSession();
        }
    }
}
