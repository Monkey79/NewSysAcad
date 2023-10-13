using NewSysAcad.DataAccess.Utils;
using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.DataAccess
{
    public interface CourseRepository : CommonCrudOps<Course>
    {
        int GetLastCourseCodeBySubjCode(int subjCode);
        Course GetByCode(int crCode);
        Response Update(Course course, int oldCrsCode);

        String DeleteAndEnrollmentsByCode(int code);
    }
}
