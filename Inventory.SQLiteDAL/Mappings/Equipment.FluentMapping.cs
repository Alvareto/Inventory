using FluentNHibernate.Mapping;

namespace Inventory
{
    public partial class EquipmentMap : ClassMap<Equipment>
    {
        public EquipmentMap()
        {
              Schema(@"main");
              Table(@"Assets");
              LazyLoad();
              Id(x => x.Id)
                .Column("AssetId")
                .CustomType("Int32")
                .Access.Property()                
                .GeneratedBy.Identity();
              Map(x => x.Active)    
                .Column("IsActive")
                .CustomType("Boolean")
                .Access.Property()
                .Generated.Never();
              Map(x => x.DateAcquired)    
                .Column("DateAcquired")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never();
              Map(x => x.DateDisposed)    
                .Column("DateDisposed")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never();
              Map(x => x.Name)    
                .Column("Name")
                .CustomType("String")
                .Access.Property()
                .Generated.Never();
              HasManyToMany<Inventory>(x => x.Users)
                .Access.Property()
                .AsBag()
                .Cascade.SaveUpdate()
                .LazyLoad()
                //.Inverse()
                .Generic()
                .Component(c => {
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
                        c.References<User>(r => r.Users, "UserId");
                        })
                .Table("Inventory")
                .FetchType.Join()
                .ChildKeyColumns.Add("UserId", mapping => mapping.Name("UserId")
                                                                     .Nullable())
                .ParentKeyColumns.Add("AssetId", mapping => mapping.Name("AssetId")
                                                                     .Nullable());
              References(x => x.Category)
                .Class<Category>()
                .Access.Property()
                .Cascade.SaveUpdate()
                .LazyLoad()
                .Columns("CategoryId");
              ExtendMapping();
        }

        #region Partial Methods

        partial void ExtendMapping();

        #endregion
    }

}
