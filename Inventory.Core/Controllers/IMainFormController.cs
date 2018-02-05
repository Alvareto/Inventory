namespace Inventory.Core
{
    public interface IMainFormController
    {
        void AddUser();
        void AddEquipment();
        void AddCategory();
        void AssignEquipment();
        void TransferEquipment();
        void DisposeEquipment();
        void DeactivateUser();
    }
}