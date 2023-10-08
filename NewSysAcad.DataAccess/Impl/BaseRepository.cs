using MySql.Data.MySqlClient;
using NewSysAcad.DataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.DataAccess.Impl
{
    public abstract class BaseRepository
    {
        protected DBConnection _dbConn;

        protected MySqlConnection _mySqlConn;
        protected MySqlCommand _mySqlCommand;
        protected MySqlDataReader _mySqlDataReader;

        protected BaseRepository() {
            _dbConn = DBConnection.GetInstance();
            _mySqlConn = _dbConn.CreateConnection();
        }
    }
}
