using LCLMS.Model;
using LCLMS.Model.Students;

namespace LCLMS.ViewModel
{
    public class StudentDetailViewModel : BaseViewModel
    {
        public StudentDetailViewModel(Student student):base(student)
        {
            Name = student.Name;
            Address = student.Address;
            Phone = student.Phone;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}