using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Model;

namespace Inventory.Core
{
    public interface IAddNewEquipmentView
    {
        bool Display(List<Category> categories);

        string EquipmentName { get; }
        Category EquipmentCategory { get; }
        DateTime DateAcquired { get; }
    }

    public interface IAddNewUserView
    {
        bool Display();

        string FirstName { get; }
        string LastName { get; }
        DateTime DateHired { get; }
    }

    public interface IAddNewCategoryView
    {
        bool Display(List<Category> categories);

        string CategoryName { get; }
        Category ParentCategory { get; }
    }

    public interface IWindowFormsFactory
    {
        IAddNewCategoryView CreateAddNewCategoryView();
        IAddNewEquipmentView CreateAddNewEquipmentView();
        IAddNewUserView CreateAddNewUserView();

        IShowUserListView CreateShowUsersListView();
        IShowEquipmentListView CreateShowEquipmentListView();
    }

    public interface IShowUserListView
    {
        void Display(IMainFormController mainController, List<User> list);
    }

    public interface IShowEquipmentListView
    {
        void Display(IMainFormController mainController, List<Equipment> list);
    }

    public interface IMainFormController
    {
        void AddUser();
        void AddEquipment();
        void AddCategory();
    }


}