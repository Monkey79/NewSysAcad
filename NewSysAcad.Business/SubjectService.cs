using NewSysAcad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Business
{
    public interface SubjectService
    {
        List<Subject> GetAllSubjects(); 
        Response CreateSubject(Subject subject);

        Response UpdateSubject(Subject subject);

        Response DeleteSubjectByCode(int code);
        Response DeleteSubjectByCodeBatch(List<int> codes);
    }
}
