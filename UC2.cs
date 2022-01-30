using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay22
{
    public class UC2
    {
        public string message;    


        public UC2(string message)
        {
            this.message = message;
        }
        public string Analyzer()
        {
            try
            {
                if (this.message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch
            {
                return "happy";
            }
        }
    }
}