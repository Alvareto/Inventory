using FluentNHibernate.Testing;
using Inventory.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Inventory.Tests
{
    [TestClass]
    public class VendorTestClass : RepositoryTestBase<CategoryRepository>
    {
        [TestMethod]
        public void Vendor_Test()
        {
            var category = CategoryFactory.CreateCategory("Test Name", null);

            new PersistenceSpecification<Category>(session)
                .CheckProperty(p => p.Id, category.Id)
                .CheckProperty(p => p.Name, category.Name)
                .CheckProperty(p => p.ParentCategory, category.ParentCategory)
                .VerifyTheMappings();
        }
    }
}