using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.DataAccess.Utils
{
    public class DBConnection
    {
        private string _databaseName;
        private string _hostName;
        private string _user;
        private string _password;
        
        private static DBConnection _instance = null;
        private MySqlConnection _mySqlConn;

        private DBConnection() {
            _databaseName = "sysacad_db";
            _hostName = "localhost";

            _user = "root";
            _password = "root";
        }

        public MySqlConnection CreateConnection() {            
            if(_mySqlConn == null) _mySqlConn = new MySqlConnection();
            
            try{
                _mySqlConn.ConnectionString = "server=" + this._hostName + ";uid=" + _user + ";pwd=" + _password + ";database=" + _databaseName;

            }catch (Exception ex){
                _mySqlConn = null;
                throw ex;
            }finally { 
                if(_mySqlConn != null) _mySqlConn.Close();
            }

            return _mySqlConn;
        }  
        
        public static DBConnection GetInstance() {
            if(_instance == null){
                _instance = new DBConnection();
            }
            return _instance;
        }
    }
}
