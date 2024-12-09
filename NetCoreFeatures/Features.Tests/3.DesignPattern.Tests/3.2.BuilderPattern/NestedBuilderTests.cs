using FluentAssertions;
using NET8_Features.src._3.DesignPattern._3._2_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8_Tests._3.DesignPattern.Tests._3._2.BuilderPattern
{
    public class NestedBuilderTests
    {
        [Fact]
        public void Test_NestedBuildTest()
        {
            var screeningInterviewBuilder = ScreeningInterview.Builder.Default();
            screeningInterviewBuilder.SetBackgroundSkill(1);
            ScreeningInterview screeningInterview = screeningInterviewBuilder.Build();

            screeningInterview.GetBackgroundSkill().Should().Be(1);

        }
    }
}
