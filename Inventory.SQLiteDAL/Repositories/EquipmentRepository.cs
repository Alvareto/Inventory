using System;
using System.Linq;
using System.Collections.Generic;
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

        public virtual Equipment GetByKey(int _Id)
        {
            return session.Get<Equipment>(_Id);
        }
    }
}
