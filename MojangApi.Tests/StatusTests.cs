using System;
using MojangApi.Requests;
using Xunit;

namespace MojangApi.Tests
{
    public class StatusTests
    {
        [Fact]
        public async System.Threading.Tasks.Task RequestRawTestAsync()
        {
            var request = new StatusRequest();
            var resp = await ClientHelper.RequestRawAsync(request);
            var content = await resp.Content.ReadAsStringAsync();
            Assert.NotEmpty(content);
            Console.WriteLine(content);
        }

        [Fact]
        public async System.Threading.Tasks.Task RequestTestAsync()
        {
            var request = new StatusRequest();
            var resp = await ClientHelper.RequestAsync(request);
            Assert.True(resp.IsSuccess);
            Assert.True(resp.Content.Count > 0);
            foreach (var item in resp.Content)
            {
                System.Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}