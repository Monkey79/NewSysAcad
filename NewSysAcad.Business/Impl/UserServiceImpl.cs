using BCrypt.Net;
using NewSysAcad.DataAccess;
using NewSysAcad.DataAccess.Impl;
using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public Response CreateUser(User user) {
            string pssHash = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password, 13);
            User userReg = _userRepository.GetByCredential(user.Name, pssHash);
            Response response = new Response();

            if (userReg != null) {
                response.Status = Response.ERROR;
                response.Message = "el usuario que desea crear ya fue registrado";
            }else {
                user.Password = pssHash;
                user.Role = UserRole.Admin;
                response = _userRepository.Save(user);
            }
            return response;
        }

        public List<User> GetAllUsers() {
            List<User> users = _userRepository.GetAll();
            if (users == null){
                Console.WriteLine("UserService: user table empty");
            }
            return users;
        }

        public User GetUserByName(User user) {
            throw new NotImplementedException();
        }
    }
}
