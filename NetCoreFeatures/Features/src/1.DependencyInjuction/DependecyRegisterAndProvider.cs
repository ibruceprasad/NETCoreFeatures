using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8.src._5.DependecnyInjuction
{
    public interface IMyDependecncy
    {
        string Name { get; set; }
    }

    public class MyDependecncy : IMyDependecncy
    {
        public string Name { get; set; } = "Initial";
    }

    public class MyDependecncyGenerator
    {
        ServiceCollection services = new ServiceCollection();
        ServiceProvider serviceProvider;
        public MyDependecncyGenerator()
        {
            services.AddTransient<IMyDependecncy, MyDependecncy>();
            serviceProvider = services.BuildServiceProvider();
        }
        public IMyDependecncy GetService() => serviceProvider.GetRequiredService<IMyDependecncy>()!;
    }
}
