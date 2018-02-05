namespace Inventory
{
    public partial interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
