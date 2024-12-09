using FluentAssertions;
using Microsoft.Extensions.Options;
using NET8_Features.src._6.DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8_Tests._6.DesignPattern
{
    public class OptionPatternUsingHostApplicationBuilderTest
    {
        [Fact]
        public void OptionPattern_Test()
        {
            var optionPattern = new OptionPatternUsingHostApplicationBuilder();
            IOptions<MyCustomConfig> options = optionPattern.GetMyCustomConfig();
            options.Should().NotBeNull();
            options.Value.Should().NotBeNull();
            options.Value.Setting1.Should().Be("hello");
            options.Value.Setting2.Should().Be(1);
        }
    }
}
