namespace Inventory.Core
{
    public interface IWindowFormsFactory
    {
        IAddNewCategoryView CreateAddNewCategoryView();
        IAddNewEquipmentView CreateAddNewEquipmentView();
        IAddNewUserView CreateAddNewUserView();

        IShowUserListView CreateShowUsersListView();
        IShowEquipmentListView CreateShowEquipmentListView();

        IAssignEquipmentView CreateAssignEquipmentView();
        ITransferEquipmentView CreateTransferEquipmentView();

        IDisposeEquipmentView CreateDisposeEquipmentView();
        IDeactivateUserView CreateDeactivateUserView();
    }
}