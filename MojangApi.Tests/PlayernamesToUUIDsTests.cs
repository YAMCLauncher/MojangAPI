using System.Linq;
using System;
using MojangApi.Requests;
using Xunit;

namespace MojangApi.Tests
{
    public class PlayernamesToUUIDsTests
    {
        [Fact]
        public async System.Threading.Tasks.Task RequestRawTestAsync()
        {
            var request = new PlayernamesToUUIDsRequest(new string[]
            {
                "MomoYoki"
            });
            var resp = await ClientHelper.RequestRawAsync(request);
            var content = await resp.Content.ReadAsStringAsync();
            Assert.NotEmpty(content);
            Console.WriteLine(content);
        }

        [Fact]
        public async System.Threading.Tasks.Task RequestTestAsync()
        {
            var request = new PlayernamesToUUIDsRequest(new string[]
            {
                "MomoYoki"
            });
            var resp = await ClientHelper.RequestAsync(request);
            Assert.True(resp.IsSuccess);
            Assert.Equal("MomoYoki", resp.Content.FirstOrDefault().Name);
        }
    }
}
