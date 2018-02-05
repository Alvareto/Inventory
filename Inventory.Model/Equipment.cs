﻿using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;

namespace Inventory
{
    public partial class Equipment : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private int _Id;

        private bool _Active;

        private System.DateTime _DateAcquired;

        private System.Nullable<System.DateTime> _DateDisposed;

        private string _Name;

        private IList<Inventory> _Users;

        private Category _Category;

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnIdChanging(int value);

        partial void OnIdChanged();
        partial void OnActiveChanging(bool value);

        partial void OnActiveChanged();
        partial void OnDateAcquiredChanging(System.DateTime value);

        partial void OnDateAcquiredChanged();
        partial void OnDateDisposedChanging(System.Nullable<System.DateTime> value);

        partial void OnDateDisposedChanged();
        partial void OnNameChanging(string value);

        partial void OnNameChanged();
        partial void OnCategoryChanging(Category value);

        partial void OnCategoryChanged();

        #endregion
        public Equipment()
        {
            this._Users = new List<Inventory>();
            OnCreated();
        }

        public virtual int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging("Id");
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if (this._Name != value)
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging("Name");
                    this._Name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        public virtual string CategoryName => Category.Name;

        public virtual Inventory CurrentInventory => Users.OrderByDescending(e => e.DateFrom).FirstOrDefault();
        public virtual User CurrentInventoryUser => CurrentInventory.Users;

        public virtual System.DateTime DateAcquired
        {
            get
            {
                return this._DateAcquired;
            }
            set
            {
                if (this._DateAcquired != value)
                {
                    this.OnDateAcquiredChanging(value);
                    this.SendPropertyChanging("DateAcquired");
                    this._DateAcquired = value;
                    this.SendPropertyChanged("DateAcquired");
                    this.OnDateAcquiredChanged();
                }
            }
        }

        public virtual System.Nullable<System.DateTime> DateDisposed
        {
            get
            {
                return this._DateDisposed;
            }
            set
            {
                if (this._DateDisposed != value)
                {
                    this.OnDateDisposedChanging(value);
                    this.SendPropertyChanging("DateDisposed");
                    this._DateDisposed = value;
                    this.SendPropertyChanged("DateDisposed");
                    this.OnDateDisposedChanged();
                }
            }
        }

        public virtual bool Active
        {
            get
            {
                return this._Active;
            }
            set
            {
                if (this._Active != value)
                {
                    this.OnActiveChanging(value);
                    this.SendPropertyChanging("Active");
                    this._Active = value;
                    this.SendPropertyChanged("Active");
                    this.OnActiveChanged();
                }
            }
        }

        public virtual IList<Inventory> Users
        {
            get
            {
                return this._Users;
            }
            set
            {
                this._Users = value;
            }
        }

        public virtual Category Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                if (this._Category != value)
                {
                    this.OnCategoryChanging(value);
                    this.SendPropertyChanging("Category");
                    this._Category = value;
                    this.SendPropertyChanged("Category");
                    this.OnCategoryChanged();
                }
            }
        }

        public virtual event PropertyChangingEventHandler PropertyChanging;

        public virtual event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName)
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
