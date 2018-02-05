using System.ComponentModel;

namespace Inventory
{
    public partial class Inventory : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private System.DateTime _DateFrom;

        private System.Nullable<System.DateTime> _DateTo;

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnDateFromChanging(System.DateTime value);

        partial void OnDateFromChanged();
        partial void OnDateToChanging(System.Nullable<System.DateTime> value);

        partial void OnDateToChanged();

        #endregion
        public Inventory()
        {
            OnCreated();
        }

        public virtual System.DateTime DateFrom
        {
            get
            {
                return this._DateFrom;
            }
            set
            {
                if (this._DateFrom != value)
                {
                    this.OnDateFromChanging(value);
                    this.SendPropertyChanging("DateFrom");
                    this._DateFrom = value;
                    this.SendPropertyChanged("DateFrom");
                    this.OnDateFromChanged();
                }
            }
        }

        public virtual System.Nullable<System.DateTime> DateTo
        {
            get
            {
                return this._DateTo;
            }
            set
            {
                if (this._DateTo != value)
                {
                    this.OnDateToChanging(value);
                    this.SendPropertyChanging("DateTo");
                    this._DateTo = value;
                    this.SendPropertyChanged("DateTo");
                    this.OnDateToChanged();
                }
            }
        }

        public virtual string UserName => Users?.Name;
        //public virtual string EquipmentName => $"[{Equipments?.CategoryName}] {Equipments?.Name}";
        public virtual bool Assigned => !_DateTo.HasValue;

        #region Ends of the many-to-many association 'Equipment_User'

        public Equipment Equipments
        {
            get;
            set;
        }

        public User Users
        {
            get;
            set;
        }

        #endregion

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
