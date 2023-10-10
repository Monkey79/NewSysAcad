using NewSysAcad.Business.Dto;
using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Business
{
    public interface UserService
    {
        List<User> GetAllUsers();

        Response CreateUser(User user);
        UserDto GetUserByCredential(UserDto userDto);
    }
}
