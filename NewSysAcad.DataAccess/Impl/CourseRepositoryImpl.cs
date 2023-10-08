using MySql.Data.MySqlClient;
using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.DataAccess.Impl
{
    public class CourseRepositoryImpl : BaseRepository, CourseRepository
    {
        private const string GET_BY_CODE = "SELECT * FROM courses WHERE cr_code=@code";

        private const string GET_ALL = "SELECT * FROM courses";

        private const string GET_LAST_CODE_BY_SBJ_CODE = "SELECT c.* " +
                                                        "FROM courses c " +
                                                        "WHERE c.cr_sb_code = (" +
                                                        "   SELECT sb_code " +
                                                        "   FROM subjects " +
                                                        "   WHERE sb_code = @subjCode" +
                                                        ") ORDER BY c.id DESC " +
                                                        "LIMIT 1";

        private const string INSERT = "INSERT INTO courses (cr_subject_name, cr_code, " +
            "cr_description, cr_maximum_quota, cr_days, cr_class_room, " +
            "cr_hr_from, cr_hr_until, cr_shift, cr_sb_code) " +
            "VALUES (@name, @code, @description, " +
            "@maximumQuota, @days, @classRoom, @hrFrom, @hrUntil, @shift, @sbjCode)";

        private const string UPDATE = "UPDATE courses " +
              "SET cr_subject_name = @name, " +
              "cr_code=@code, "+ 
              "cr_description = @description, " +
              "cr_maximum_quota = @maximumQuota, " +
              "cr_days = @days, " +
              "cr_class_room = @classRoom, " +
              "cr_hr_from = @hrFrom, " +
              "cr_hr_until = @hrUntil, " +
              "cr_shift = @shift " +
              "WHERE cr_code = @crCode";

        public CourseRepositoryImpl():base() {

        }

        public Response Delete(Course t)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll() {
            Console.WriteLine("*****CourseRepo.GetAll*******");
            List<Course> courses = new List<Course>();
            Course course = null;
            try
            {
                _mySqlConn.Open();
                _mySqlCommand = new MySqlCommand(GET_ALL, _mySqlConn);
                _mySqlDataReader = _mySqlCommand.ExecuteReader();

                while (_mySqlDataReader.Read()){
                    course = new Course();
                    course.Id = _mySqlDataReader.GetInt32("id");
                    course.SubjectName = _mySqlDataReader.GetString("cr_subject_name");
                    course.Code = _mySqlDataReader.GetInt32("cr_code");
                    course.Description = _mySqlDataReader.GetString("cr_description");
                    course.MaximumQuota = _mySqlDataReader.GetInt32("cr_maximum_quota");
                    course.Days = _mySqlDataReader.GetInt32("cr_days");
                    course.ClassRoom = _mySqlDataReader.GetInt32("cr_class_room");
                    course.HrFrom = _mySqlDataReader.GetInt32("cr_hr_from");
                    course.HrUntil = _mySqlDataReader.GetInt32("cr_hr_until");
                    course.Shift = (SHIFT)_mySqlDataReader.GetInt32("cr_shift");
                    course.SubjCode = _mySqlDataReader.GetInt32("cr_sb_code");
                    courses.Add(course);
                }
                _mySqlDataReader.Close();
            }catch (Exception ex){
                Console.WriteLine("err: " + ex.Message);
                throw ex;
            }finally{
                if(_mySqlConn!=null) _mySqlConn.Close();
            }
            return courses;
        }

        public Course GetBYCode(int crCode) {
            Console.WriteLine("*****[REPO] GetByCode*******");
            Course course = null;
            try{
                _mySqlConn.Open();
                _mySqlCommand = new MySqlCommand(GET_BY_CODE, _mySqlConn);
                _mySqlCommand.Parameters.AddWithValue("@code", crCode);
                _mySqlDataReader = _mySqlCommand.ExecuteReader();

                while (_mySqlDataReader.Read()){
                    course = new Course();
                    course.Id = _mySqlDataReader.GetInt32("id");
                    course.SubjectName = _mySqlDataReader.GetString("cr_subject_name");
                    course.Code = _mySqlDataReader.GetInt32("cr_code");
                    course.Description = _mySqlDataReader.GetString("cr_description");
                    course.MaximumQuota = _mySqlDataReader.GetInt32("cr_maximum_quota");
                    course.Days = _mySqlDataReader.GetInt32("cr_days");
                    course.ClassRoom = _mySqlDataReader.GetInt32("cr_class_room");
                    course.HrFrom = _mySqlDataReader.GetInt32("cr_hr_from");
                    course.HrUntil = _mySqlDataReader.GetInt32("cr_hr_until");
                    course.Shift = (SHIFT)_mySqlDataReader.GetInt32("cr_shift");
                    course.SubjCode = _mySqlDataReader.GetInt32("cr_sb_code");
                }
                _mySqlDataReader.Close();
            }catch (Exception ex){
                Console.WriteLine("err: " + ex.Message);
                throw ex;
            }finally {
                if(_mySqlConn!=null) _mySqlConn.Close();
            }
            return course;
        }

        public Course GetById(int id){
            throw new NotImplementedException();
        }

        public int GetLastCourseCodeBySubjCode(int subjCode) {
            Console.WriteLine("*****CourseRepo.GetLastCode*******");
            List<Course> courses = new List<Course>();
            int lastCode=0;
            try{
                _mySqlConn.Open();
                _mySqlCommand = new MySqlCommand(GET_LAST_CODE_BY_SBJ_CODE, _mySqlConn);
                _mySqlCommand.Parameters.AddWithValue("@subjCode", subjCode);
                _mySqlDataReader = _mySqlCommand.ExecuteReader();

                while (_mySqlDataReader.Read()){
                    lastCode = _mySqlDataReader.GetInt32("cr_code");                   
                }
                _mySqlDataReader.Close();
            }catch (Exception ex){
                Console.WriteLine("err: " + ex.Message);
                throw ex;
            }finally{
                if (_mySqlConn != null) _mySqlConn.Close();
            }
            return lastCode;
        }

        public Response Save(Course course) {
            Console.WriteLine("*****[REPO]Save.Course*******");
            Response resp = new Response();
            int rowsAffected = 0;
            try
            {
                _mySqlConn.Open();
                _mySqlCommand = new MySqlCommand(INSERT, _mySqlConn);

                _mySqlCommand.Parameters.AddWithValue("@name", course.SubjectName);
                _mySqlCommand.Parameters.AddWithValue("@code", course.Code);
                _mySqlCommand.Parameters.AddWithValue("@description", course.Description);
                _mySqlCommand.Parameters.AddWithValue("@maximumQuota", course.MaximumQuota);
                _mySqlCommand.Parameters.AddWithValue("@days", course.Days);
                _mySqlCommand.Parameters.AddWithValue("@classRoom", course.ClassRoom);
                _mySqlCommand.Parameters.AddWithValue("@hrFrom", course.HrFrom);
                _mySqlCommand.Parameters.AddWithValue("@hrUntil", course.HrUntil);
                _mySqlCommand.Parameters.AddWithValue("@shift", course.Shift);
                _mySqlCommand.Parameters.AddWithValue("@sbjCode", course.SubjCode);

                rowsAffected = _mySqlCommand.ExecuteNonQuery();
                if (rowsAffected == 1){
                    resp.Status = Response.OK;
                    resp.Message = "course creation success";
                }else {
                    resp.Status = Response.ERROR;
                    resp.Message = "course creation unsuccess";
                }                    
            }catch (Exception ex){
                Console.WriteLine("err:" + ex.Message);
                throw ex;
            }finally{
                if(_mySqlConn!=null) _mySqlConn.Close();
            }
            return resp;
        }

        public Response Update(Course t) {
            throw new NotImplementedException();
        }

        public Response Update(Course course, int oldCrsCode){
            Console.WriteLine("*****[REPO]UPDATE.Course*******");
            Response resp = new Response();
            int rowsAffected = 0;
            try{
                _mySqlConn.Open();
                _mySqlCommand = new MySqlCommand(UPDATE, _mySqlConn);

                _mySqlCommand.Parameters.AddWithValue("@name", course.SubjectName);
                _mySqlCommand.Parameters.AddWithValue("@code", course.Code);
                _mySqlCommand.Parameters.AddWithValue("@description", course.Description);
                _mySqlCommand.Parameters.AddWithValue("@maximumQuota", course.MaximumQuota);
                _mySqlCommand.Parameters.AddWithValue("@days", course.Days);
                _mySqlCommand.Parameters.AddWithValue("@classRoom", course.ClassRoom);
                _mySqlCommand.Parameters.AddWithValue("@hrFrom", course.HrFrom);
                _mySqlCommand.Parameters.AddWithValue("@hrUntil", course.HrUntil);
                _mySqlCommand.Parameters.AddWithValue("@shift", course.Shift);
                _mySqlCommand.Parameters.AddWithValue("@sbjCode", course.SubjCode);

                _mySqlCommand.Parameters.AddWithValue("@crCode", oldCrsCode);

                rowsAffected = _mySqlCommand.ExecuteNonQuery();
                if (rowsAffected == 1){
                    resp.Status = Response.OK;
                    resp.Message = "course update success";
                }else{
                    resp.Status = Response.ERROR;
                    resp.Message = "course update unsuccess";
                }
            }catch (Exception ex){
                Console.WriteLine("err:" + ex.Message);
                throw ex;
            }finally{
                if (_mySqlConn != null) _mySqlConn.Close();
            }
            return resp;
        }
    }
}
