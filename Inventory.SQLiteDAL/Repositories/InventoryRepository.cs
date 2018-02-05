using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;

namespace Inventory
{
    public partial class InventoryRepository : NHibernateRepository<Inventory>, IInventoryRepository
    {
        private static InventoryRepository _instance;

        private InventoryRepository(ISession session) : base(session)
        {
        }

        public static InventoryRepository GetInstance(ISession session)
        {
            return _instance ?? (_instance = new InventoryRepository(session));
        }

        public virtual Inventory GetLatest(Equipment equipment)
        {
            //var inv = session.Get<Equipment>(equipment.Id).Users.Where(e => e.DateTo == null);

            var inventory = equipment.Users.Where(e => e.DateTo == null).OrderByDescending(e => e.DateFrom).FirstOrDefault();

            return inventory;
        }

        public virtual Inventory GetLatest(User user)
        {
            //var inv = session.Get<User>(user.Id).Equipments;

            var inventory = user.Equipments.Where(e => e.DateTo == null).OrderByDescending(e => e.DateFrom).FirstOrDefault();

            return inventory;
        }

        public virtual ICollection<Inventory> GetAll()
        {
            return session.CreateQuery(string.Format("from Inventory")).List<Inventory>();
        }

        public virtual void Add(Equipment e, User u)
        {

        }

        public virtual void Transfer(Equipment e, User u, DateTime transferDate)
        {

        }
    }
}