using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcad.Entities
{
    public class Response
    {
        public static string OK = "OK";
        public static string ERROR = "Error";

        private string _status;
        private string _message;
                
        private List<string> _messages;

        public Response() {
            _messages = new List<string>();
        }

        public string Status { get => _status; set => _status = value; }
        public string Message { get => _message; set => _message = value; }
        public List<string> Messages { get => _messages;}
    }
}
