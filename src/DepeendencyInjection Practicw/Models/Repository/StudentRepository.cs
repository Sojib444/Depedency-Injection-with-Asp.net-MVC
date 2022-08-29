using DepeendencyInjection_Practicw.Models.Ireppository;

namespace DepeendencyInjection_Practicw.Models.Repository
{
    public class StudentRepository : IStudent
    {
        public int add(Student student)
        {
            return  student.Id;
        }
    }
}
