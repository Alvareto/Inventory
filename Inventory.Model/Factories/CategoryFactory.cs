namespace Inventory.Model
{
    public class CategoryFactory
    {
        public static Category CreateCategory(string name, Category parent)
        {
            var c = new Category();

            c.Name = name;

            if (parent != null)
                c.ParentCategory = parent;

            return c;
        }
    }
}