namespace Inventory.Core
{
    public interface IWindowFormsFactory
    {
        IAddNewCategoryView CreateAddNewCategoryView();
        IAddNewEquipmentView CreateAddNewEquipmentView();
        IAddNewUserView CreateAddNewUserView();

        IShowUserListView CreateShowUsersListView();
        IShowEquipmentListView CreateShowEquipmentListView();
    }
}