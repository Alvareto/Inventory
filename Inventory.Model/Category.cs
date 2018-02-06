using System.Collections.Generic;
using System.ComponentModel;

namespace Inventory
{
    public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
    {
        private static readonly PropertyChangingEventArgs emptyChangingEventArgs =
            new PropertyChangingEventArgs(string.Empty);

        private IList<Category> _ChildCategories;

        private IList<Equipment> _Equipments;

        private int _Id;

        private string _Name;

        private Category _ParentCategory;

        public Category()
        {
            _Equipments = new List<Equipment>();
            _ChildCategories = new List<Category>();
            OnCreated();
        }

        public virtual int Id
        {
            get => _Id;
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    SendPropertyChanging("Id");
                    _Id = value;
                    SendPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }

        public virtual string Name
        {
            get => _Name;
            set
            {
                if (_Name != value)
                {
                    OnNameChanging(value);
                    SendPropertyChanging("Name");
                    _Name = value;
                    SendPropertyChanged("Name");
                    OnNameChanged();
                }
            }
        }

        public virtual IList<Equipment> Equipments
        {
            get => _Equipments;
            set => _Equipments = value;
        }

        public virtual IList<Category> ChildCategories
        {
            get => _ChildCategories;
            set => _ChildCategories = value;
        }

        public virtual Category ParentCategory
        {
            get => _ParentCategory;
            set
            {
                if (_ParentCategory != value)
                {
                    OnParentCategoryChanging(value);
                    SendPropertyChanging("ParentCategory");
                    _ParentCategory = value;
                    SendPropertyChanged("ParentCategory");
                    OnParentCategoryChanged();
                }
            }
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        public virtual event PropertyChangingEventHandler PropertyChanging;

        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(string propertyName)
        {
            var handler = PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnIdChanging(int value);

        partial void OnIdChanged();
        partial void OnNameChanging(string value);

        partial void OnNameChanged();
        partial void OnParentCategoryChanging(Category value);

        partial void OnParentCategoryChanged();

        #endregion
    }
}