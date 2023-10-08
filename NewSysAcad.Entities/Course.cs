using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace NewSysAcad.Entities
{
    public enum SHIFT { 
        Morning=1,
        Late,
        Night    
    }
    public class Course
    {
        private int _id;
        private string _subjectName;
        private int _code; //codigo (unico)
        private string _description;
        private int _maximumQuota;
        private int _days; //dias de la cursada
        private int _classRoom;
        private int _hrFrom;
        private int _hrUntil;
        private SHIFT _shift;

        private int _subjCode;

        public int Id { get => _id; set => _id = value; }
        public string SubjectName { get => _subjectName; set => _subjectName = value; }
        public int Code { get => _code; set => _code = value; }
        public string Description { get => _description; set => _description = value; }
        public int MaximumQuota { get => _maximumQuota; set => _maximumQuota = value; }
        public int Days { get => _days; set => _days = value; }
        public int ClassRoom { get => _classRoom; set => _classRoom = value; }
        public int HrFrom { get => _hrFrom; set => _hrFrom = value; }
        public int HrUntil { get => _hrUntil; set => _hrUntil = value; }
        public SHIFT Shift { get => _shift; set => _shift = value; }
        public int SubjCode { get => _subjCode; set => _subjCode = value; }

        public override string ToString(){
            return base.ToString();
        }
    }
}
