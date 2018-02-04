
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Inventory.Domain
{
    public class Equipment
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        //public string Category { get; set; }
        //public virtual double Price { get; set; }
        //public bool Discontinued { get; set; }

        public virtual Category Category { get; set; }

        //public virtual void AddCategory()
        //{

        //}
    }

    public class Category
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }

        public virtual Category ParentCategory { get; set; }
        public virtual IList<Category> Categories { get; set; }

        public virtual IList<Equipment> Products { get; protected set; }

        public Category()
        {
            Products = new List<Equipment>();
            Categories = new List<Category>();

        }
    }

    public class User
    {
        public virtual int Id { get; protected set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public virtual DateTime EmployedDate { get; set; }
        public virtual DateTime? FiredDate { get; set; }
    }

    public class Inventory
    {
        public virtual int Id { get; protected set; }
        public virtual Equipment Equipment { get; set; }
        public virtual User User { get; set; }
        public virtual DateTime DateFrom { get; set; }
        public virtual DateTime DateTo { get; set; }
    }
}
