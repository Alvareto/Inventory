using System.ComponentModel;
using System.Collections.Generic;

namespace Inventory
{
    public partial class Settings : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private IList<User> _Administrators;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion
        public Settings()
        {
            this._Administrators = new List<User>();
            OnCreated();
        }

        public virtual IList<User> Administrators
        {
            get
            {
                return this._Administrators;
            }
            set
            {
                this._Administrators = value;
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
