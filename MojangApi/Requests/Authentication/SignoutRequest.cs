using MojangApi.Responses.Authentication;
using Newtonsoft.Json;

namespace MojangApi.Requests.Authentication
{
    public class SignoutRequest : Request<SignoutResponse, SignoutResponse.ResponseContent>
    {
        public override string AuthenticationEndpoint => "signout";

        public string Username { get; }
        public string Password { get; set; }

        public SignoutRequest(
            string username,
            string password
        )
        {
            Username = username;
            Password = password;
        }

        public override string AuthenticationPayload()
        {
            return JsonConvert.SerializeObject(new
            {
                Username,
                Password
            }, jsonSerializerSettings);
        }
    }
}