using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.DataAccess.Utils
{
    public interface CommonCrudOps<T>  
    {
        Response Save(T t);
        Response Delete(T t);
        Response Update(T t);
        List<T> GetAll();        
        T GetById(int id);
    }
}
