using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCLMS.Model;
using LCLMS.Model.Teachers;

namespace LCLMS.ViewModel
{
    public class TeacherDetailViewModel:BaseViewModel
    {
        public TeacherDetailViewModel(Teacher teacher):base(teacher)
        {
            this.Name = teacher.Name;
        }
        public string Name { get; set; }

    }
}
