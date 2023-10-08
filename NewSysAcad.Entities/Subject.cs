using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Entities
{
    public class Subject
    {
        private int _id;
        private int _code;
        private string _name;
        private string _headProfessor;

        private List<Course> _courses;

        public int Id { get => _id; set => _id = value; }
        public int Code { get => _code; set => _code = value; }
        public string Name { get => _name; set => _name = value; }
        public string HeadProfessor { get => _headProfessor; set => _headProfessor = value; }
        public List<Course> Courses { get => _courses; set => _courses = value; }

        //[Browsable(false)]
        public string CodeAndName {
            get { return $"{Code}-{Name}"; }
        }
    }
}
