using FluentNHibernate.Mapping;

namespace Inventory
{
    public partial class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Schema(@"main");
            Table(@"Category");
            LazyLoad();
            Id(x => x.Id)
                .Column("CategoryId")
                .CustomType("Int32")
                .Access.Property()
                .GeneratedBy.Identity();
            Map(x => x.Name)
                .Column("Name")
                .CustomType("String")
                .Access.Property()
                .Generated.Never();
            HasMany(x => x.Equipments)
                .Access.Property()
                .AsBag()
                .Cascade.SaveUpdate()
                .LazyLoad()
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Inverse()
                .Generic()
                .KeyColumns.Add("CategoryId", mapping => mapping.Name("CategoryId")
                    .Nullable());
            HasMany(x => x.ChildCategories)
                .Access.Property()
                .AsBag()
                .Cascade.SaveUpdate()
                .LazyLoad()
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Inverse()
                .Generic()
                .KeyColumns.Add("ParentId", mapping => mapping.Name("ParentId")
                    .Nullable());
            References(x => x.ParentCategory)
                .Class<Category>()
                .Access.Property()
                .Cascade.SaveUpdate()
                .LazyLoad()
                .Columns("ParentId");
            ExtendMapping();
        }

        #region Partial Methods

        partial void ExtendMapping();

        #endregion
    }
}