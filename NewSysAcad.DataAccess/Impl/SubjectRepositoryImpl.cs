using MySql.Data.MySqlClient;
using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NewSysAcad.DataAccess.Impl
{
    public class SubjectRepositoryImpl : BaseRepository, SubjectRepository
    {
        private static string GET_ALL = "SELECT * FROM subjects";
        private static string INSERT = "INSERT INTO subjects (sb_code, sb_name, sb_head_professor) " +
                                       "VALUES (@sbCode, @sbName, @sbHdPrf)";
        private static string GET_BY_CODE = "SELECT * FROM subjects " +
                                            "WHERE sb_code=@sbCode";

        private static string UPDATE = "UPDATE subjects " +
                                        "SET sb_name = @sbName, " +
                                        "sb_head_professor = @sbHdPrf " +
                                        "WHERE sb_code=@sbCode";
        public SubjectRepositoryImpl():base() {

        }

        public Response Delete(Subject t)
        {
            throw new NotImplementedException();
        }

        public List<Subject> GetAll() {
            Console.WriteLine("*****Subject.GetAll*******");
            List<Subject> subjects = new List<Subject>();
            Subject subject = null;
            try{
                _mySqlConn.Open();
                _mySqlCommand = new MySqlCommand(GET_ALL, _mySqlConn);
                _mySqlDataReader = _mySqlCommand.ExecuteReader();

                while (_mySqlDataReader.Read()){
                    subject = new Subject();
                    subject.Id = _mySqlDataReader.GetInt32("id");
                    subject.Code = _mySqlDataReader.GetInt32("sb_code");
                    subject.Name = _mySqlDataReader.GetString("sb_name");
                    subject.HeadProfessor = _mySqlDataReader.GetString("sb_head_professor");

                    subjects.Add(subject);
                }
                _mySqlDataReader.Close();
            }catch (Exception ex){
                Console.WriteLine("err: " + ex.Message);
                throw ex;
            }finally{
                if(_mySqlConn!=null) _mySqlConn.Close();
            }
            return subjects;
        }

        public Subject GetById(int code) {
            Console.WriteLine("*****Subject.GetById*******");
            Subject subject = null;
            try {
                _mySqlConn.Open();
                _mySqlCommand = new MySqlCommand(GET_BY_CODE, _mySqlConn);
                _mySqlCommand.Parameters.AddWithValue("@sbCode", code);
                _mySqlDataReader = _mySqlCommand.ExecuteReader();

                while (_mySqlDataReader.Read()){
                    subject = new Subject();
                    subject.Id = _mySqlDataReader.GetInt32("id");
                    subject.Code = _mySqlDataReader.GetInt32("sb_code");
                    subject.Name = _mySqlDataReader.GetString("sb_name");
                    subject.HeadProfessor = _mySqlDataReader.GetString("sb_head_professor");
                }
                _mySqlDataReader.Close();
            }catch (Exception ex){
                Console.WriteLine("err: " + ex.Message);
                throw ex;
            }finally{
                if (_mySqlConn != null) _mySqlConn.Close();
            }
            return subject;
        }

        public Response Save(Subject subject) {
            Console.WriteLine("*****SubjRepo.SAVE*******");
            bool rslt = false;
            int rowsAffected = 0;
            Response response = new Response();

            try{
                _mySqlConn.Open();
                _mySqlCommand = new MySqlCommand(INSERT, _mySqlConn);

                _mySqlCommand.Parameters.AddWithValue("@sbCode", subject.Code);
                _mySqlCommand.Parameters.AddWithValue("@sbName", subject.Name);
                _mySqlCommand.Parameters.AddWithValue("@sbHdPrf", subject.HeadProfessor);

                rowsAffected = _mySqlCommand.ExecuteNonQuery();
                if (rowsAffected == 1){
                    response.Status = Response.OK;
                    response.Message = "creation subject success";
                }else {
                    response.Status = Response.ERROR;
                    response.Message = "creation subject unsuccess";
                }
            }catch (Exception ex) {
                Console.WriteLine("err:" + ex.Message);
                throw ex;
            }finally{
                if(_mySqlConn!=null) _mySqlConn.Close();
            }
            return response;
        }

        public Response Update(Subject subject){
            Console.WriteLine("*****SubjRepo.UPDATE*******");
            bool rslt = false;
            int rowsAffected = 0;
            Response response = new Response();

            try {
                _mySqlConn.Open();
                _mySqlCommand = new MySqlCommand(UPDATE, _mySqlConn);

                _mySqlCommand.Parameters.AddWithValue("@sbCode", subject.Code);
                _mySqlCommand.Parameters.AddWithValue("@sbName", subject.Name);
                _mySqlCommand.Parameters.AddWithValue("@sbHdPrf", subject.HeadProfessor);

                rowsAffected = _mySqlCommand.ExecuteNonQuery();
                if (rowsAffected == 1){
                    response.Status = Response.OK;
                    response.Message = "update subject success";
                }else{
                    response.Status = Response.ERROR;
                    response.Message = "update subject unsuccess";
                }
            }catch (Exception ex){
                Console.WriteLine("err:" + ex.Message);
                throw ex;
            }finally{
                if (_mySqlConn != null) _mySqlConn.Close();
            }
            return response;
        }
    }
}
