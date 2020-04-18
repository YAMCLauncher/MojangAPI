using System.Net.Http;

namespace MojangApi.Responses.Authentication
{
    public class SignoutResponse : Response<SignoutResponse.ResponseContent>
    {
        public SignoutResponse(HttpResponseMessage message, string content) : base(message, content)
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