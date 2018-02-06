using System;
using System.ComponentModel;

namespace Inventory
{
    public partial class Inventory : INotifyPropertyChanging, INotifyPropertyChanged
    {
        private static readonly PropertyChangingEventArgs emptyChangingEventArgs =
            new PropertyChangingEventArgs(string.Empty);

        private DateTime _DateFrom;

        private DateTime? _DateTo;

        public Inventory()
        {
            OnCreated();
        }

        public virtual DateTime DateFrom
        {
            get => _DateFrom;
            set
            {
                if (_DateFrom != value)
                {
                    OnDateFromChanging(value);
                    SendPropertyChanging("DateFrom");
                    _DateFrom = value;
                    SendPropertyChanged("DateFrom");
                    OnDateFromChanged();
                }
            }
        }

        public virtual DateTime? DateTo
        {
            get => _DateTo;
            set
            {
                if (_DateTo != value)
                {
                    OnDateToChanging(value);
                    SendPropertyChanging("DateTo");
                    _DateTo = value;
                    SendPropertyChanged("DateTo");
                    OnDateToChanged();
                }
            }
        }

        public virtual string UserName => Users?.Name;

        //public virtual string EquipmentName => $"[{Equipments?.CategoryName}] {Equipments?.Name}";
        public virtual bool Assigned => !_DateTo.HasValue;

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
        partial void OnDateFromChanging(DateTime value);

        partial void OnDateFromChanged();
        partial void OnDateToChanging(DateTime? value);

        partial void OnDateToChanged();

        #endregion

        #region Ends of the many-to-many association 'Equipment_User'

        public Equipment Equipments { get; set; }

        public User Users { get; set; }

        #endregion
    }
}