using System;
using System.Threading.Tasks;
using Learning.Controllers;
using Xunit;

namespace Test
{
    public class AsyncAPITest
    {
        [Fact]
        public async Task Get_ReturnsTrue()
        {
            var controller = new AsyncTestController();
            var result = await controller.GetTest();
            Assert.True(result);
        }

        [Fact]
        public async Task Get_MultippeAwaitsReturnsTrue()
        {
            var controller = new AsyncTestController();
            var result = await controller.GetTestMultiple();
            Assert.True(result);
        }
    }
}
