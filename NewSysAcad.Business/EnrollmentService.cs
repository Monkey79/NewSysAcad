using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Business
{
    public interface EnrollmentService
    {
        Response DeleteEnrollmentByCourseCode(int  courseCode);
    }
}
