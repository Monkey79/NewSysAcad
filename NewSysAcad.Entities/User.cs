using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Entities
{
    public enum UserRole { 
        Admin = 1,
        Studen
    }
    public class User
    {
        private int _id;
        private string _name;
        private string _password;
        private UserRole _role;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Password { get => _password; set => _password = value; }
        public UserRole Role { get => _role; set => _role = value; }
    }
}
