using NewSysAcad.DataAccess.Utils;
using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.DataAccess
{
    public interface UserRepository : CommonCrudOps<User>
    {
        User GetByCredential(string userName, string password);
    }
}
