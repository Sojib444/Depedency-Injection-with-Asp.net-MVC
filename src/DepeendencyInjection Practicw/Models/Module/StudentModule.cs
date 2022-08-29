using Autofac;
using DepeendencyInjection_Practicw.Models.Ireppository;
using DepeendencyInjection_Practicw.Models.Repository;

namespace DepeendencyInjection_Practicw
{
    public class StudentModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<StudentRepository>().As<IStudent>();
            base.Load(builder);
        }
    }
}
