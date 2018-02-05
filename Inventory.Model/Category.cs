using System.ComponentModel;
using System.Collections.Generic;

namespace Inventory
{
    public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);

        private int _Id;

        private string _Name;

        private IList<Equipment> _Equipments;

        private IList<Category> _ChildCategories;

        private Category _ParentCategory;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        partial void OnIdChanging(int value);
        
        partial void OnIdChanged();
        partial void OnNameChanging(string value);
        
        partial void OnNameChanged();
        partial void OnParentCategoryChanging(Category value);

        partial void OnParentCategoryChanged();
        
        #endregion
        public Category()
        {
            this._Equipments = new List<Equipment>();
            this._ChildCategories = new List<Category>();
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

        public virtual IList<Equipment> Equipments
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

        public virtual IList<Category> ChildCategories
        {
            get
            {
                return this._ChildCategories;
            }
            set
            {
                this._ChildCategories = value;
            }
        }

        public virtual Category ParentCategory
        {
            get
            {
                return this._ParentCategory;
            }
            set
            {
                if (this._ParentCategory != value)
                {
                    this.OnParentCategoryChanging(value);
                    this.SendPropertyChanging("ParentCategory");
                    this._ParentCategory = value;
                    this.SendPropertyChanged("ParentCategory");
                    this.OnParentCategoryChanged();
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
