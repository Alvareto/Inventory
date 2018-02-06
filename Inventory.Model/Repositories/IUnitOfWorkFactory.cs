namespace Inventory
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}