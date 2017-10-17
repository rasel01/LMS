using LCLMS.Model.Students;
using LCLMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCLMS.Service
{
    public class StudentService
    {
        public bool Add(Student student)
        {
            StudentRepository repository = new StudentRepository();
            return repository.Add(student);
        }

    }
}
