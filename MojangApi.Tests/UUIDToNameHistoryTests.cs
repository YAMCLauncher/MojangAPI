using System;
using MojangApi.Requests;
using Xunit;

namespace MojangApi.Tests
{
    public class UUIDToNameHistoryTests
    {
        [Fact]
        public async System.Threading.Tasks.Task RequestRawTestAsync()
        {
            var request = new UUIDToNameHistoryRequest("00992bb84f6949b990dc309476a1426b");
            var resp = await ClientHelper.RequestRawAsync(request);
            var content = await resp.Content.ReadAsStringAsync();
            Assert.NotEmpty(content);
            Console.WriteLine(content);
        }

        [Fact]
        public async System.Threading.Tasks.Task RequestTestAsync()
        {
            var request = new UUIDToNameHistoryRequest("00992bb84f6949b990dc309476a1426b");
            var resp = await ClientHelper.RequestAsync(request);
            Assert.True(resp.IsSuccess);
            Assert.Equal("chang196700", resp.Content[0].Name);
        }
    }
}