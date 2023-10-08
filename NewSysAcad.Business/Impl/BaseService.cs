using NewSysAcad.DataAccess.Impl;
using NewSysAcad.DataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Business.Impl
{
    public abstract class BaseService
    {
        protected RepositoryMng _repMng; //TODO not used yet, improve

        public BaseService() {
            _repMng = RepositoryMng.GetInstance();
        }
    }
}
