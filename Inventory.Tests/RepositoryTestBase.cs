using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;

namespace Inventory.Tests
{
    /// <summary>
    /// Class RepositoryTestBase will create a session in start of a Test Fixture, and create all database schema , and then close it at the end of the fixture.
    /// Then by just inheriting from that class , you can write unit tests that will test your repository transactions to the database.
    /// </summary>
    [TestClass]
    public class RepositoryTestBase<T> where T : new()
    {
        protected T repository;
        protected ISession session;
        protected ITransaction transaction;

        protected static ISessionFactory SessionFactory => NHibernateTestConfiguration.SessionFactory;

        [ClassInitialize]
        public void SetupClass()
        {
            session = SessionFactory.OpenSession();
            CurrentSessionContext.Bind(session);
            var cfg = NHibernateTestConfiguration.Configuration;
            var schemaExport = new SchemaExport(cfg);
            schemaExport.Execute(true, true, false, session.Connection, Console.Out);
        }

        [TestInitialize]
        public virtual void Setup()
        {
            repository = new T();
            session.FlushMode = FlushMode.Always;
            transaction = session.BeginTransaction();
        }

        [TestCleanup]
        public virtual void Cleanup()
        {
            transaction.Rollback();
            repository = default(T);
        }

        [ClassCleanup]
        public void CleanupClass()
        {
            var _session = CurrentSessionContext.Unbind(SessionFactory);
            _session.Close();
        }
    }
}
