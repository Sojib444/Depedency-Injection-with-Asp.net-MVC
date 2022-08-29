

using Autofac;
using DepeendencyInjection_Practicw.Models.Ireppository;
using DepeendencyInjection_Practicw.Models.Repository;

namespace DepeendencyInjection_Practicw
{
    public class TeacherModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<TeacherRepository>().As<ITeacher>();
            base.Load(builder);
        }
    }
}
