using LCLMS.Model;
using LCLMS.Model.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCLMS.Repository
{
    public class TeacherRepository
    {
        private BusinessDbContext db;
        public TeacherRepository()
        {
            db = new BusinessDbContext();
        }
        public bool Add(Teacher teacher)
        {
            teacher.Id = Guid.NewGuid().ToString();
            this.db.Teachers.Add(teacher);
            int result = this.db.SaveChanges();
            return result > 0;
        }
    }
}
