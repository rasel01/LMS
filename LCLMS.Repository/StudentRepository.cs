using LCLMS.Model;
using LCLMS.Model.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCLMS.Repository
{
    public class StudentRepository
    {

        private BusinessDbContext db;

        public StudentRepository()
        {
            this.db = new BusinessDbContext();
        }
        public bool Add(Student student)
        {
            student.Id = Guid.NewGuid().ToString();
            this.db.students.Add(student);
            int savechanges = this.db.SaveChanges();
            return savechanges > 0;
        }

        

    }
}
