using MojangApi.Responses.Authentication;
using Newtonsoft.Json;

namespace MojangApi.Requests.Authentication
{
    public class ValidateRequest : Request<ValidateResponse, ValidateResponse.ResponseContent>
    {
        public override string AuthenticationEndpoint => "validate";
        public string AccessToken { get; }
        public string ClientToken { get; }

        public ValidateRequest(string accessToken, string clientToken = null)
        {
            this.AccessToken = accessToken;
            this.ClientToken = clientToken;
        }

        public override string AuthenticationPayload()
        {
            string json;
            if (ClientToken == null)
            {
                json = JsonConvert.SerializeObject(new
                {
                    AccessToken
                });
            }
            else
            {
                json = JsonConvert.SerializeObject(new
                {
                    AccessToken,
                    ClientToken
                });
            }

            return json;
        }
    }
}