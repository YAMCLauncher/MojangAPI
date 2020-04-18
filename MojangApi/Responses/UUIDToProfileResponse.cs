using System.Net.Http;
using MojangApi.Models;
using Newtonsoft.Json;

namespace MojangApi.Responses
{
    public class UUIDToProfileResponse : Response<UUIDToProfileResponse.ResponseContent>
    {
        public UUIDToProfileResponse(HttpResponseMessage message, string content) : base(message, content)
        {
        }

        protected override void Parse(HttpResponseMessage message, string content)
        {
            var raw = JsonConvert.DeserializeObject<RawPlayerProfile>(content);
            Content = new ResponseContent(raw);
        }

        public class ResponseContent : PlayerProfile, IResponseContent
        {
            public ResponseContent(RawPlayerProfile rawProfile) : base(rawProfile)
            {
            }
        }
    }
}