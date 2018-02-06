using System;

namespace Inventory.Model
{
    public class UserFactory
    {
        public static User CreateUser(string fName, string lName, DateTime dateHired)
        {
            return new User
            {
                FirstName = fName,
                LastName = lName,
                Active = true,
                DateHired = dateHired,
                DateFired = null
            };
        }

        public static User CreateDefaultUser(string lName)
        {
            return new User
            {
                FirstName = "Administrator",
                LastName = lName,
                Active = true,
                DateHired = DateTime.Today,
                DateFired = null
            };
        }
    }
}