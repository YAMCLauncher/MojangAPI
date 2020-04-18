using MojangApi.Responses.Authentication;
using Newtonsoft.Json;

namespace MojangApi.Requests.Authentication
{
    public class RefreshRequest : Request<RefreshResponse, RefreshResponse.ResponseContent>
    {
        public override string AuthenticationEndpoint => "refresh";

        public string AccessToken { get; }
        public string ClientToken { get; }
        public bool RequestUser { get; }

        public RefreshRequest(
            string accessToken,
            string clientToken = null,
            bool requestUser = false
        )
        {
            AccessToken = accessToken;
            ClientToken = clientToken;
            RequestUser = requestUser;
        }

        public override string AuthenticationPayload()
        {
            string json;
            if (ClientToken == null)
            {
                json = JsonConvert.SerializeObject(new
                {
                    AccessToken,
                    RequestUser
                }, jsonSerializerSettings);
            }
            else
            {
                json = JsonConvert.SerializeObject(new
                {
                    AccessToken,
                    ClientToken,
                    RequestUser
                }, jsonSerializerSettings);
            }

            return json;
        }
    }
}