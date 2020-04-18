using MojangApi.Models.Authentication;
using MojangApi.Responses.Authentication;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MojangApi.Requests.Authentication
{
    public class AuthenticateRequest : Request<AuthenticateResponse, AuthenticateResponse.ResponseContent>
    {
        public override string AuthenticationEndpoint => "authenticate";

        public Agent Agent { get; }
        public string Username { get; }
        public string Password { get; }
        public string ClientToken { get; }
        public bool RequestUser { get; }

        public AuthenticateRequest(
            Agent agent,
            string username,
            string password,
            string clientToken = null,
            bool requestUser = false
        )
        {
            Agent = agent;
            Username = username;
            Password = password;
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
                    Agent,
                    Username,
                    Password,
                    RequestUser
                }, jsonSerializerSettings);
            }
            else
            {
                json = JsonConvert.SerializeObject(new
                {
                    Agent,
                    Username,
                    Password,
                    ClientToken,
                    RequestUser
                }, jsonSerializerSettings);
            }

            return json;
        }
    }
}