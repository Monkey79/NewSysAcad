using NewSysAcad.Business.Dto;
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

        public Response CreateUser(User user){
            Response response = new Response();
            User userReg = _userRepository.GetByName(user.Name);
            if (userReg != null){
                response.Status = Response.ERROR;
                response.Message = "el usuario que desea crear ya esta registrado";
            }else{
                string pswHsh = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password, 13);
                user.Password = pswHsh;
                user.Role = UserRole.Admin; //change
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

        public UserDto GetUserByCredential(UserDto userDto) {
            User userReg = _userRepository.GetByName(userDto.UserName);
            UserDto userLogedDto = new UserDto();

            if (userReg != null){
                bool hsRslt = BCrypt.Net.BCrypt.EnhancedVerify(userDto.Password, userReg.Password);
                if (hsRslt){
                    userLogedDto.UserName = userReg.Name;
                    userLogedDto.UserRole = userReg.Role.ToString();
                    userLogedDto.LoginStatus = UserDto.OK;
                    userLogedDto.LoginMssg = UserDto.SUCCESS_MSG;
                }else{
                    userLogedDto.LoginStatus = UserDto.ERROR;
                    userLogedDto.LoginMssg = UserDto.ERROR_MSG;
                }
            }
            return userLogedDto;
        }
    }
}
