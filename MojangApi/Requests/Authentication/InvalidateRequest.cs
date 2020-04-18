using MojangApi.Responses.Authentication;
using Newtonsoft.Json;

namespace MojangApi.Requests.Authentication
{
    public class InvalidateRequest : Request<InvalidateResponse, InvalidateResponse.ResponseContent>
    {
        public override string AuthenticationEndpoint => "invalidate";

        public string AccessToken { get; }
        public string ClientToken { get; }

        public InvalidateRequest(
            string accessToken,
            string clientToken
        )
        {
            AccessToken = accessToken;
            ClientToken = clientToken;
        }

        public override string AuthenticationPayload()
        {
            return JsonConvert.SerializeObject(new
            {
                AccessToken,
                ClientToken
            }, jsonSerializerSettings);
        }
    }
}