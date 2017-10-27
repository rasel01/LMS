using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCLMS.RequestModel
{
    public class StudentRequestModel
    {
        public StudentRequestModel()
        {
            Page = 1;
            PerpageCount = 10;
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Page { get; set; }
        public int PerpageCount { get; set; }
        public string OrderBy { get; set; }
        public bool IsAcesnding { get; set; }
    }
}
