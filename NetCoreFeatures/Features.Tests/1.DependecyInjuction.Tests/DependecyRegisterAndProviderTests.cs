using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Practice_.Net8.src._5.DependecnyInjuction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8_Tests._5.DependecyInjuction
{
    public class DependecyRegisterAndProviderTests
    {

        [Fact]
        public void Verify_Transient_Objects()
        {
            MyDependecncyGenerator myDependecncyGenerator = new MyDependecncyGenerator();
            IMyDependecncy instance_1 = myDependecncyGenerator.GetService();
            IMyDependecncy instance_2 = myDependecncyGenerator.GetService();
            instance_1.Name = "Sam";
            instance_2.Name.Should().Be("Initial");
            instance_2.Name.Should().NotBe("Sam");
        }




    }
}
