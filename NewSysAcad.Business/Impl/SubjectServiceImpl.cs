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
    public class SubjectServiceImpl : BaseService,SubjectService
    {
        private SubjectRepository _subjectRepo;

        public SubjectServiceImpl() {
            _subjectRepo = new SubjectRepositoryImpl();
        }

        public Response CreateSubject(Subject subject){
            Response response=null;
            Subject crSubj = _subjectRepo.GetById(subject.Code);

            if (crSubj == null){
                Console.WriteLine("***Subject.SAVING******");
                response = _subjectRepo.Save(subject);
            }else {
                response = new Response();
                response.Status = Response.ERROR;
                response.Message = "Ya existe una materia con el codigo: "+subject.Code;
            }

            return response;
        }

        public Response DeleteSubjectByCode(int code) {
            throw new NotImplementedException();
        }

        public Response DeleteSubjectByCodeBatch(List<int> codes) {
            foreach (int code in codes){
                Console.WriteLine("-Subject to delete Code=" + code);
            }
            throw new NotImplementedException();
        }

        public List<Subject> GetAllSubjects() {
            List<Subject> list = _subjectRepo.GetAll();
            if (list == null) {
                Console.WriteLine("SubjectService: table subjects is empty");
            }
            return list;
        }

        public Response UpdateSubject(Subject subject) {
            Response response = null;
            Subject crSubj = _subjectRepo.GetById(subject.Code);

            if (crSubj == null){
                response = new Response();
                response.Status = Response.ERROR;
                response.Message = "NO existe la materia con el codigo: " + subject.Code+" que quiere actualzar";                
            }else {
                response = _subjectRepo.Update(subject);
            }

            return response;
        }
    }
}
