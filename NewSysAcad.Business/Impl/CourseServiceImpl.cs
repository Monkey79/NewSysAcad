using NewSysAcad.DataAccess;
using NewSysAcad.DataAccess.Impl;
using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Business.Impl
{
    public class CourseServiceImpl : BaseService, CourseService
    {
        private CourseRepository _courseRep;

        public CourseServiceImpl(){
            _courseRep = new CourseRepositoryImpl();
        }

        public Response CreateCourse(Course course){
            Course courseCrtd = _courseRep.GetBYCode(course.Code);
            Response createdResp = new Response();
            if (courseCrtd != null){
                createdResp.Status = Response.ERROR;
                createdResp.Message = "curso ya existe";
            }else {
                createdResp = _courseRep.Save(course);
            }
            return createdResp;
        }

        public List<Course> GetAllCourses(){
            List<Course> courses = _courseRep.GetAll();
            if(courses == null) {
                Console.WriteLine("CourseService: courses table empty");
            }
            return courses;
        }

        public int GetLastCourseCodeBySubjectCode(int subjCode) {
            int lastSbjCode=0;
            if (subjCode > 0){
                lastSbjCode = _courseRep.GetLastCourseCodeBySubjCode(subjCode);
            }else {
                Console.WriteLine("CourseService: subject code invalid");
            }
            return lastSbjCode;
        }

        public Response UpdateCourse(Course course, int oldCrsCode) {
            Course courseCrtd = _courseRep.GetBYCode(oldCrsCode);
            Response updatedResp = new Response();
            if (courseCrtd == null) {
                updatedResp.Status = Response.ERROR;
                updatedResp.Message = "curso que quiere actualizar NO existe";
            }else{
                updatedResp = _courseRep.Update(course, oldCrsCode);
            }
            return updatedResp;
        }
    }
}
