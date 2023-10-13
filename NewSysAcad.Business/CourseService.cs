using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Business
{
    public interface CourseService
    {
        List<Course> GetAllCourses();
        int GetLastCourseCodeBySubjectCode(int subjCode);
        Response CreateCourse(Course course);
        Response UpdateCourse(Course course, int oldCrsCode);

        Response DeleteCourseAndTheirEnrollmentsByCode(List<int> codes);
    }
}
