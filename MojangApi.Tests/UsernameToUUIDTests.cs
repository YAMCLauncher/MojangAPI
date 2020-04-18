using System;
using MojangApi.Requests;
using Xunit;

namespace MojangApi.Tests
{
    public class UsernameToUUIDTests
    {
        [Fact]
        public async System.Threading.Tasks.Task RequestRawTestAsync()
        {
            var request = new UsernameToUUIDRequest("chang196700");
            var resp = await ClientHelper.RequestRawAsync(request);
            var content = await resp.Content.ReadAsStringAsync();
            Assert.NotEmpty(content);
            Console.WriteLine(content);
        }

        [Fact]
        public async System.Threading.Tasks.Task RequestTestAsync()
        {
            var request = new UsernameToUUIDRequest("chang196700");
            var resp = await ClientHelper.RequestAsync(request);
            Assert.True(resp.IsSuccess);
            Assert.Equal("00992bb84f6949b990dc309476a1426b", resp.Content.Id);
        }
    }
}