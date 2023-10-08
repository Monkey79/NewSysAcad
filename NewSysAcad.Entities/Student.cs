using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Entities
{
    public class Student
    {
        private int _id;
        private string _name;
        private string surname;
        private int _fileNumber; //legajo (unico)
        private string _address;
        private string _phoneNumber;        
        private string _emailAccount;
        private bool _changePassword;

        private List<Payment> _payments;
        private List<Enrollment> _enrollments;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int FileNumber { get => _fileNumber; set => _fileNumber = value; }
        public string Address { get => _address; set => _address = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string EmailAccount { get => _emailAccount; set => _emailAccount = value; }
        public bool ChangePassword { get => _changePassword; set => _changePassword = value; }
        public List<Payment> Payments { get => _payments; set => _payments = value; }
        public List<Enrollment> Enrollments { get => _enrollments; set => _enrollments = value; }
    }
}
