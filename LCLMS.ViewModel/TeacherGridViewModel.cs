using LCLMS.Model.Teachers;

namespace LCLMS.ViewModel
{
    public class TeacherGridViewModel:BaseViewModel
    {
        public TeacherGridViewModel(Teacher teacher) : base(teacher)
        {
            this.Name = teacher.Name;
        }
        public string Name { get; set; }
    }
}