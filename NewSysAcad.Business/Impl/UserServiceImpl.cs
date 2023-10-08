using NewSysAcad.DataAccess;
using NewSysAcad.DataAccess.Impl;
using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Business.Impl
{
    public class UserServiceImpl : BaseService, UserService
    {
        private UserRepository _userRepository;

        public UserServiceImpl() {
            _userRepository = new UserRepositoryImpl();
        }

        public List<User> GetAllUsers() {
            List<User> users = _userRepository.GetAll();
            if (users == null){
                Console.WriteLine("UserService: user table empty");
            }
            return users;
        }
    }
}
