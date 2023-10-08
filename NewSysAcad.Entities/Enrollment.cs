using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace NewSysAcad.Entities
{
    public class Enrollment
    {
        private int _id;
        private int _stFileNumber; //fk
        private int _crCode; //fk
        private string _subjectName;
        private int classRoom;
        private DateTime _creationDate;
        private int _days;
        private int _hrFrom;
        private int _hrUntil;
        private int _shift;
    }
}
