using MySql.Data.MySqlClient;
using NewSysAcad.DataAccess.Utils;
using NewSysAcad.Entities;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


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

        public User GetByName(string userName) {
            MySqlConnection _mySqlConn = _dbConn.CreateConnection();
            User user = null;

            try{
                _mySqlConn.Open();
                _mySqlCommand = new MySqlCommand(GET_BY_NAME, _mySqlConn);
                _mySqlCommand.Parameters.AddWithValue("@name", userName);                
                _mySqlDataReader = _mySqlCommand.ExecuteReader();

                while (_mySqlDataReader.Read()){
                    user = new User();
                    user.Id = _mySqlDataReader.GetInt32("id");
                    user.Name = _mySqlDataReader.GetString("us_name");
                    user.Password = _mySqlDataReader.GetString("us_password");
                    user.Role = (UserRole)_mySqlDataReader.GetInt32("us_role");
                }
            }catch (Exception e){
                throw e;
            }finally{
                if (_mySqlConn != null) _mySqlConn.Close();
            }
            return user;
        }

        public Response Save(User user){
            Console.WriteLine("*****SubjRepo.SAVE*******");
            bool rslt = false;
            int rowsAffected = 0;
            Response response = new Response();

            try {
                _mySqlConn.Open();
                _mySqlCommand = new MySqlCommand(INSERT_USER, _mySqlConn);

                _mySqlCommand.Parameters.AddWithValue("@userName", user.Name);
                _mySqlCommand.Parameters.AddWithValue("@password", user.Password);
                _mySqlCommand.Parameters.AddWithValue("@role", user.Role);

                rowsAffected = _mySqlCommand.ExecuteNonQuery();
                if (rowsAffected == 1){
                    response.Status = Response.OK;
                    response.Message = "creation user success";
                }else{
                    response.Status = Response.ERROR;
                    response.Message = "creation user unsuccess";
                }
            }catch (Exception ex){
                Console.WriteLine("err:" + ex.Message);
                throw ex;
            }finally{
                if (_mySqlConn != null) _mySqlConn.Close();
            }
            return response;
        }

        public Response Update(User t)
        {
            throw new NotImplementedException();
        }
    }
}
