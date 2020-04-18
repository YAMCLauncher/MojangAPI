using System.Net.Http;

namespace MojangApi.Responses
{
    public class SkinResponse : Response<SkinResponse.ResponseContent>
    {
        public SkinResponse(HttpResponseMessage message, string content) : base(message, content)
        {
        }

        protected override void Parse(HttpResponseMessage message, string content)
        {
        }

        public class ResponseContent : IResponseContent
        {
        }
    }
}