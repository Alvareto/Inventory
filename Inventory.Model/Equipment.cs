using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Inventory
{
    public partial class Equipment : INotifyPropertyChanging, INotifyPropertyChanged
    {
        private static readonly PropertyChangingEventArgs emptyChangingEventArgs =
            new PropertyChangingEventArgs(string.Empty);

        private bool _Active;

        private Category _Category;

        private DateTime _DateAcquired;

        private DateTime? _DateDisposed;

        private int _Id;

        private string _Name;

        private IList<Inventory> _Users;

        public Equipment()
        {
            _Users = new List<Inventory>();
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

        public virtual string CategoryName => Category.Name;

        public virtual Inventory CurrentInventory => Users.OrderByDescending(e => e.DateFrom).FirstOrDefault();
        public virtual User CurrentInventoryUser => CurrentInventory.Users;

        public virtual DateTime DateAcquired
        {
            get => _DateAcquired;
            set
            {
                if (_DateAcquired != value)
                {
                    OnDateAcquiredChanging(value);
                    SendPropertyChanging("DateAcquired");
                    _DateAcquired = value;
                    SendPropertyChanged("DateAcquired");
                    OnDateAcquiredChanged();
                }
            }
        }

        public virtual DateTime? DateDisposed
        {
            get => _DateDisposed;
            set
            {
                if (_DateDisposed != value)
                {
                    OnDateDisposedChanging(value);
                    SendPropertyChanging("DateDisposed");
                    _DateDisposed = value;
                    SendPropertyChanged("DateDisposed");
                    OnDateDisposedChanged();
                }
            }
        }

        public virtual bool Active
        {
            get => _Active;
            set
            {
                if (_Active != value)
                {
                    OnActiveChanging(value);
                    SendPropertyChanging("Active");
                    _Active = value;
                    SendPropertyChanged("Active");
                    OnActiveChanged();
                }
            }
        }

        public virtual IList<Inventory> Users
        {
            get => _Users;
            set => _Users = value;
        }

        public virtual Category Category
        {
            get => _Category;
            set
            {
                if (_Category != value)
                {
                    OnCategoryChanging(value);
                    SendPropertyChanging("Category");
                    _Category = value;
                    SendPropertyChanged("Category");
                    OnCategoryChanged();
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
        partial void OnActiveChanging(bool value);

        partial void OnActiveChanged();
        partial void OnDateAcquiredChanging(DateTime value);

        partial void OnDateAcquiredChanged();
        partial void OnDateDisposedChanging(DateTime? value);

        partial void OnDateDisposedChanged();
        partial void OnNameChanging(string value);

        partial void OnNameChanged();
        partial void OnCategoryChanging(Category value);

        partial void OnCategoryChanged();

        #endregion
    }
}