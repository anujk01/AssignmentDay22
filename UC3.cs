using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay22
{
    public class UC3 : Exception
    {
        ExceptionType type;
        public string message;

        public enum ExceptionType
        {
            Null, Empty
        }
        public UC3(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}