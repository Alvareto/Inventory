namespace Inventory
{
    public partial interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
    }
}
