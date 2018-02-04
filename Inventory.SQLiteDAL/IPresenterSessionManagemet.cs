using NHibernate;

namespace Inventory.Core
{
    public interface IPresenterSessionManagemet
    {
        ISession Session { get; }
        IStatelessSession StatelessSession { get; }
    }
}