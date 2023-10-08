using NewSysAcad.DataAccess.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.DataAccess.Impl
{
    public class RepositoryMng
    {
        public const string USER_REPO = "UserRepo";

        private static RepositoryMng _instance = null;

        private RepositoryMng() {

        }
        public static RepositoryMng GetInstance() { 
            if(_instance == null)
                _instance = new RepositoryMng();
            return _instance;
        }

        public BaseRepository GetRepoyById(string id) {
            BaseRepository repo = null;
            switch(id){
                case USER_REPO:
                    repo = new UserRepositoryImpl();
                    break;               

            }
            return repo;
        }
    }
}
