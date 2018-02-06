using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Inventory
{
    public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
    {
        private static readonly PropertyChangingEventArgs emptyChangingEventArgs =
            new PropertyChangingEventArgs(string.Empty);

        private bool _Active;

        private DateTime? _DateFired;

        private DateTime _DateHired;

        private IList<Inventory> _Equipments;

        private string _FirstName;

        private int _Id;

        private string _LastName;

        public User()
        {
            _Equipments = new List<Inventory>();
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

        public virtual string Name => $"{FirstName} {LastName}";

        public virtual string FirstName
        {
            get => _FirstName;
            set
            {
                if (_FirstName != value)
                {
                    OnFirstNameChanging(value);
                    SendPropertyChanging("FirstName");
                    _FirstName = value;
                    SendPropertyChanged("FirstName");
                    OnFirstNameChanged();
                }
            }
        }

        public virtual string LastName
        {
            get => _LastName;
            set
            {
                if (_LastName != value)
                {
                    OnLastNameChanging(value);
                    SendPropertyChanging("LastName");
                    _LastName = value;
                    SendPropertyChanged("LastName");
                    OnLastNameChanged();
                }
            }
        }

        public virtual DateTime DateHired
        {
            get => _DateHired;
            set
            {
                if (_DateHired != value)
                {
                    OnDateHiredChanging(value);
                    SendPropertyChanging("DateHired");
                    _DateHired = value;
                    SendPropertyChanged("DateHired");
                    OnDateHiredChanged();
                }
            }
        }

        public virtual DateTime? DateFired
        {
            get => _DateFired;
            set
            {
                if (_DateFired != value)
                {
                    OnDateFiredChanging(value);
                    SendPropertyChanging("DateFired");
                    _DateFired = value;
                    SendPropertyChanged("DateFired");
                    OnDateFiredChanged();
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

        public virtual IList<Equipment> Inventory => Equipments.Select(e => e.Equipments).ToList();

        public virtual IList<Inventory> Equipments
        {
            get => _Equipments;
            set => _Equipments = value;
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
        partial void OnFirstNameChanging(string value);

        partial void OnFirstNameChanged();
        partial void OnLastNameChanging(string value);

        partial void OnLastNameChanged();
        partial void OnDateHiredChanging(DateTime value);

        partial void OnDateHiredChanged();
        partial void OnDateFiredChanging(DateTime? value);

        partial void OnDateFiredChanged();
        partial void OnActiveChanging(bool value);

        partial void OnActiveChanged();

        #endregion
    }
}