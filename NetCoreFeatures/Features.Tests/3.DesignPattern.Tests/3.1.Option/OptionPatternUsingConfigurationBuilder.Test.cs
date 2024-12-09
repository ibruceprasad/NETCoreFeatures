using FluentAssertions;
using Microsoft.Extensions.Options;
using NET8_Features.src._6.DesignPattern;
using NET8_Features.src.DesignPattern;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8_Tests.DesignPattern
{
    public class OptionPatternUsingConfigurationBuilderTest
    {
        [Fact]
        public void OptionPattern_Test()
        {
            var optionPattern = new OptionPatternUsingConfigurationBuilder();
            IOptions<MyCustomConfig> options  = optionPattern.GetMyCustomConfig();
            options.Should().NotBeNull();   
            options.Value.Should().NotBeNull();
            options.Value.Setting1.Should().Be("hello");
            options.Value.Setting2.Should().Be(1);
        }
    }
}