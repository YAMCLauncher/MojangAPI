using System.Net.Http;

namespace MojangApi.Responses.Authentication
{
    public class ValidateResponse : Response<ValidateResponse.ResponseContent>
    {
        public ValidateResponse(HttpResponseMessage message, string content) : base(message, content)
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