namespace Inventory.Core
{
    public interface IInventoryController
    {
        void Assign(IAssignEquipmentView inForm);
        void Transfer(ITransferEquipmentView inForm);
    }
}