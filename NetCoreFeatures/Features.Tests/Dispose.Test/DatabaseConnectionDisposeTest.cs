using FluentAssertions;
using Practice_.Net8.src;
using Xunit.Sdk;

namespace Practice_.Net8_Tests
{
    public class DatabaseConnectionDisposeTest
    {
        [Fact]
        public void WhenRuntimeExceptionOccured_ThenDisposeCalledAutomatically()
        {
            var IsDisposeCalled = false;
            try
            {
                // using is mst to invoke Dispose
                using DatabaseConnectionDispose dbdispose = new DatabaseConnectionDispose();
                throw new DivideByZeroException();
            }
            catch (Exception ex)
            {
                SharedFlag.IsDisposed.Should().Be(true);
            }
        }
        [Fact]
        public void GivenWithoutUsingClause_ReturnsDisposeNotBeCalled()
        {
            var IsDisposeCalled = false;
            try
            {
                DatabaseConnectionDispose dbdispose = new DatabaseConnectionDispose();
                throw new DivideByZeroException();
            }
            catch (Exception ex)
            {
                SharedFlag.IsDisposed.Should().Be(false);
            }
        }


    }
}