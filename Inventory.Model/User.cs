﻿using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;

namespace Inventory
{
    public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private int _Id;

        private string _FirstName;

        private string _LastName;

        private System.DateTime _DateHired;

        private System.Nullable<System.DateTime> _DateFired;

        private bool _Active;

        private IList<Inventory> _Equipments;

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnIdChanging(int value);

        partial void OnIdChanged();
        partial void OnFirstNameChanging(string value);

        partial void OnFirstNameChanged();
        partial void OnLastNameChanging(string value);

        partial void OnLastNameChanged();
        partial void OnDateHiredChanging(System.DateTime value);

        partial void OnDateHiredChanged();
        partial void OnDateFiredChanging(System.Nullable<System.DateTime> value);

        partial void OnDateFiredChanged();
        partial void OnActiveChanging(bool value);

        partial void OnActiveChanged();

        #endregion
        public User()
        {
            this._Equipments = new List<Inventory>();
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
        public virtual string Name => $"{FirstName} {LastName}";
        public virtual string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                if (this._FirstName != value)
                {
                    this.OnFirstNameChanging(value);
                    this.SendPropertyChanging("FirstName");
                    this._FirstName = value;
                    this.SendPropertyChanged("FirstName");
                    this.OnFirstNameChanged();
                }
            }
        }

        public virtual string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                if (this._LastName != value)
                {
                    this.OnLastNameChanging(value);
                    this.SendPropertyChanging("LastName");
                    this._LastName = value;
                    this.SendPropertyChanged("LastName");
                    this.OnLastNameChanged();
                }
            }
        }

        public virtual System.DateTime DateHired
        {
            get
            {
                return this._DateHired;
            }
            set
            {
                if (this._DateHired != value)
                {
                    this.OnDateHiredChanging(value);
                    this.SendPropertyChanging("DateHired");
                    this._DateHired = value;
                    this.SendPropertyChanged("DateHired");
                    this.OnDateHiredChanged();
                }
            }
        }

        public virtual System.Nullable<System.DateTime> DateFired
        {
            get
            {
                return this._DateFired;
            }
            set
            {
                if (this._DateFired != value)
                {
                    this.OnDateFiredChanging(value);
                    this.SendPropertyChanging("DateFired");
                    this._DateFired = value;
                    this.SendPropertyChanged("DateFired");
                    this.OnDateFiredChanged();
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

        public virtual IList<Equipment> Inventory => Equipments.Select(e => e.Equipments).ToList();

        public virtual IList<Inventory> Equipments
        {
            get
            {
                return this._Equipments;
            }
            set
            {
                this._Equipments = value;
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
