using FluentNHibernate.Mapping;

namespace Inventory
{
    public partial class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Schema(@"main");
            Table(@"Users");
            LazyLoad();
            Id(x => x.Id)
                .Column("UserId")
                .CustomType("Int32")
                .Access.Property()
                .GeneratedBy.Identity();
            Map(x => x.FirstName)
                .Column("FirstName")
                .CustomType("String")
                .Access.Property()
                .Generated.Never();
            Map(x => x.LastName)
                .Column("LastName")
                .CustomType("String")
                .Access.Property()
                .Generated.Never();
            Map(x => x.DateHired)
                .Column("DateHired")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never();
            Map(x => x.DateFired)
                .Column("DateFired")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never();
            Map(x => x.Active)
                .Column("IsActive")
                .CustomType("Boolean")
                .Access.Property()
                .Generated.Never();
            HasManyToMany(x => x.Equipments)
                .Access.Property()
                .AsBag()
                .Cascade.SaveUpdate()
                .LazyLoad()
                .Inverse()
                .Generic()
                .Component(c =>
                {
                    c.Map(x => x.DateFrom)
                        .Column("DateFrom")
                        .CustomType("DateTime")
                        .Access.Property()
                        .Generated.Never();
                    c.Map(x => x.DateTo)
                        .Column("DateTo")
                        .CustomType("DateTime")
                        .Access.Property()
                        .Generated.Never();
                    c.References(r => r.Equipments, "AssetId");
                })
                .Table("Inventory")
                .FetchType.Join()
                .ChildKeyColumns.Add("AssetId", mapping => mapping.Name("AssetId")
                    .Nullable())
                .ParentKeyColumns.Add("UserId", mapping => mapping.Name("UserId")
                    .Nullable());
            ExtendMapping();
        }

        #region Partial Methods

        partial void ExtendMapping();

        #endregion
    }
}