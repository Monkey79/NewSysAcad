using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Business.Dto
{
    public class UserDto
    {
        public static string OK = "OK";
        public static string ERROR = "Error";
        public static string ERROR_MSG = "Invalid credentials";
        public static string SUCCESS_MSG = "Valid credentials, wellcome";

        private string _loginStatus;
        private string _loginMssg;

        private string _userName;
        private string _password;        
        private string _userRole;

        public UserDto() {
        }

        public UserDto(string userName, string password) {
            _userName = userName;
            _password = password;
        }

        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public string UserRole { get => _userRole; set => _userRole = value; }
        public string LoginStatus { get => _loginStatus; set => _loginStatus = value; }
        public string LoginMssg { get => _loginMssg; set => _loginMssg = value; }
    }
}
