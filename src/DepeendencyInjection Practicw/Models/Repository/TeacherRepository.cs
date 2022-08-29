using DepeendencyInjection_Practicw.Models.Ireppository;

namespace DepeendencyInjection_Practicw.Models.Repository
{
    public class TeacherRepository : ITeacher
    {
        public string add(Teacher teacher)
        {
            return teacher.name="Abir";
        }
    }
}
