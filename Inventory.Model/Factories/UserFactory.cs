using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    public class UserFactory
    {
        public static User CreateUser(string fName, string lName, DateTime dateHired)
        {
            return new User()
            {
                FirstName = fName,
                LastName = lName,
                Active = true,
                DateHired = dateHired,
                DateFired = null
            };
        }
    }
}
