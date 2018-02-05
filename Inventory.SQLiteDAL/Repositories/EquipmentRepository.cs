using System;
using System.Linq;
using System.Collections.Generic;
using Inventory.Core;
using NHibernate;
using NHibernate.Linq;

namespace Inventory
{
    public partial class EquipmentRepository : NHibernateRepository<Equipment>, IEquipmentRepository
    {
        private static EquipmentRepository _instance;

        private EquipmentRepository(ISession session) : base(session)
        {
        }

        public static EquipmentRepository GetInstance(ISession session)
        {
            return _instance ?? (_instance = new EquipmentRepository(session));
        }

        public virtual ICollection<Equipment> GetAll()
        {
            return session.CreateQuery(string.Format("from Equipment")).List<Equipment>();
        }

        public ICollection<Equipment> GetAllUnassigned()
        {
            var eq = session.Query<Equipment>()
                .FetchMany(e => e.Users)
                .Where(e => e.Active).ToList();
            var inv = eq.SelectMany(e => e.Users).Where(e => e.DateTo != null || e.Users.LastName.Equals(Constants.ADMINISTRATOR_LASTNAME)).ToList();

            return inv.Select(r => r.Equipments).Distinct().ToList();
        }

        public ICollection<Equipment> GetAllAssigned()
        {
            var eq = session.Query<Equipment>()
                .FetchMany(e => e.Users)
                .Where(e => e.Active).ToList();
            var inv = eq.SelectMany(e => e.Users).Where(e => e.DateTo == null).ToList();

            return inv.Select(r => r.Equipments).Distinct().ToList();

            //return session.Query<Inventory>().Fetch(e => e.Equipments).Where(e => e.Equipments.Active && e.DateTo != null)
            //    .Select(e => e.Equipments)
            //    .ToList();
        }

        public virtual Equipment GetByKey(int _Id)
        {
            return session.Get<Equipment>(_Id);
        }

        public Dictionary<Equipment, User> MapInventory()
        {
            var map = new Dictionary<Equipment, User>();
            return map;

            //var map = session.Query<Inventory>().Fetch(u => u.Users).Fetch(u => u.Equipments)
            //    .Where(u => u.Users.Active && u.Equipments.Active)
            //    .Select(u => new KeyValuePair<Equipment, User>(u.Equipments, u.Users))
            //    .ToList();

            //return map.ToDictionary(pair => pair.Key, pair => pair.Value);
        }


    }
}
