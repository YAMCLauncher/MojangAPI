using System.Net;
using System.Net.Http;
using MojangApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MojangApi.Responses
{
    public class UsernameToUUIDResponse : Response<UsernameToUUIDResponse.ResponseContent>
    {
        public UsernameToUUIDResponse(HttpResponseMessage message, string content) : base(message, content)
        {
        }

        protected override void Parse(HttpResponseMessage message, string content)
        {
            if (StatusCode == HttpStatusCode.NoContent) return;

            Content = JsonConvert.DeserializeObject<ResponseContent>(content);
        }

        public class ResponseContent : PlayerUUID, IResponseContent
        {
            public ResponseContent(string id, string name, bool? legacy, bool? demo) : base(id, name, legacy, demo)
            {
            }
        }
    }
}
