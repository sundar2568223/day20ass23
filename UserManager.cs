using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppass23
{
    public class UserManager
    {
        internal string name;
        internal string email;
        private DataValidator validator;

        public UserManager()
        {
            validator = new DataValidator();
        }

        public void AddUser(string name, string email)
        {
            if (validator.IsValidEmail(email))
            {
                // Your user management logic here (simplified for example)
                Console.WriteLine($"User '{name}' with email '{email}' added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid email format. User not added.");
            }
        }
    }

}
