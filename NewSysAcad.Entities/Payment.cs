using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Entities
{
    public class Payment
    {
        private int _id;
        private int _stFileNumber; //fk
        private string _concept;
        private int _pyAmount;
        private bool _settled;

        public int Id { get => _id; set => _id = value; }
        public int StFileNumber { get => _stFileNumber; set => _stFileNumber = value; }
        public string Concept { get => _concept; set => _concept = value; }
        public int PyAmount { get => _pyAmount; set => _pyAmount = value; }
        public bool Settled { get => _settled; set => _settled = value; }
    }
}
