using System.Collections.Generic;
using System.ComponentModel;

namespace Inventory
{
    public partial class Settings : INotifyPropertyChanging, INotifyPropertyChanged
    {
        private static readonly PropertyChangingEventArgs emptyChangingEventArgs =
            new PropertyChangingEventArgs(string.Empty);

        private IList<User> _Administrators;

        public Settings()
        {
            _Administrators = new List<User>();
            OnCreated();
        }

        public virtual IList<User> Administrators
        {
            get => _Administrators;
            set => _Administrators = value;
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        public virtual event PropertyChangingEventHandler PropertyChanging;

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion

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
    }
}