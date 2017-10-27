using LCLMS.Model.Students;
using LCLMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCLMS.RequestModel;

namespace LCLMS.Service
{
    public class StudentService
    {
        private StudentRepository repository;

        public StudentService()
        {
            this.repository = new StudentRepository();
        }
        public bool Add(Student student)
        {
            return repository.Add(student);
        }

        public List<Student> Search(StudentRequestModel request)
        {
            //Get Quaryable data 
            IQueryable<Student> students = this.repository.Get();
            //condition apply
           
            if (!string.IsNullOrWhiteSpace(request.Name))
            {
                students = students.Where(x => x.Name.ToLower().Contains(request.Name.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(request.Phone))
            {
                students = students.Where(x => x.Phone.ToLower().Contains(request.Phone.ToLower()));
            }

            students = students.OrderBy(x => x.ModifiedBy);

            if (!String.IsNullOrWhiteSpace(request.OrderBy))
            {
                if (request.OrderBy.ToLower() == "name")
                {
                    students = request.IsAcesnding
                        ? students.OrderBy(x => x.Name)
                        : students.OrderByDescending(x => x.Name);
                }

                if (request.OrderBy.ToLower() == "phone")
                {
                    students = request.IsAcesnding
                        ? students.OrderBy(x => x.Phone)
                        : students.OrderByDescending(x => x.Phone);
                }
            }
            



            students = students.Skip((request.Page - 1) * 10).Take(request.PerpageCount);
            List<Student> list = students.ToList();
            return list;
        }

    }
}
