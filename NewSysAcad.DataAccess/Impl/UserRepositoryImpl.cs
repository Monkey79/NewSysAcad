using MySql.Data.MySqlClient;
using NewSysAcad.DataAccess.Utils;
using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.DataAccess.Impl
{
    public class UserRepositoryImpl : BaseRepository, UserRepository
    {
        private const string GET_BY_NAME = "SELECT * from users WHERE us_name=@name";
        private const string GET_ALL     = "SELECT * FROM users";
        private const string INSERT_USER = "INSERT INTO users(us_name, us_password, us_role) " +
                                            "VALUES(@userName, @password, @role)";

        public UserRepositoryImpl() : base() {
            _dbConn = DBConnection.GetInstance();
        }
        public Response Delete(User t){
            throw new NotImplementedException();
        }

        public List<User> GetAll(){
            List<User> users = new List<User>();
            MySqlConnection _mySqlConn = _dbConn.CreateConnection();
            User user = null;

            try {                
                _mySqlConn.Open();
                _mySqlCommand = new MySqlCommand(GET_ALL, _mySqlConn);
                _mySqlDataReader = _mySqlCommand.ExecuteReader();

                while (_mySqlDataReader.Read()) {
                    user = new User();
                    user.Id = _mySqlDataReader.GetInt32("id");
                    user.Name = _mySqlDataReader.GetString("us_name");
                    user.Password = _mySqlDataReader.GetString("us_password");
                    user.Role = (UserRole)_mySqlDataReader.GetInt32("us_role");

                    users.Add(user);
                }
            }catch (Exception e) {
                throw e;
            } finally { 
                if(_mySqlConn != null) _mySqlConn.Close();
            }
            return users;
        }

        public User GetById(int id){
            throw new NotImplementedException();
        }

        public User GetByUserName(string userName) {
            throw new NotImplementedException();
        }

        public Response Save(User t){
            throw new NotImplementedException();
        }

        public Response Update(User t)
        {
            throw new NotImplementedException();
        }
    }
}
