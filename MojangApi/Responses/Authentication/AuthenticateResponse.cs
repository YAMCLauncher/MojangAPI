using System.Collections.Generic;
using System.Net.Http;
using MojangApi.Models.Authentication;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MojangApi.Responses.Authentication
{
    public class AuthenticateResponse : Response<AuthenticateResponse.ResponseContent>
    {
        public AuthenticateResponse(HttpResponseMessage message, string content) : base(message, content)
        {
        }

        protected override void Parse(HttpResponseMessage message, string content)
        {
            Content = JsonConvert.DeserializeObject<ResponseContent>(content);
        }

        public class ResponseContent : IResponseContent
        {
            public ResponseContent(
                string accessToken,
                string clientToken,
                List<Profile> availableProfiles,
                Profile selectedProfile,
                User user
            )
            {
                AccessToken = accessToken;
                ClientToken = clientToken;
                AvailableProfiles = availableProfiles.AsReadOnly();
                SelectedProfile = selectedProfile;
                User = user;
            }

            public string AccessToken { get; }
            public string ClientToken { get; }
            public IReadOnlyCollection<Profile> AvailableProfiles { get; }
            public Profile SelectedProfile { get; }
            public User User { get; }
        }
    }
}