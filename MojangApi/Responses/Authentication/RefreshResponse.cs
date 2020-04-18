using System.Net.Http;
using MojangApi.Models.Authentication;
using Newtonsoft.Json;

namespace MojangApi.Responses.Authentication
{
    public class RefreshResponse : Response<RefreshResponse.ResponseContent>
    {
        public RefreshResponse(HttpResponseMessage message, string content) : base(message, content)
        {
        }

        protected override void Parse(HttpResponseMessage message, string content)
        {
            Content = JsonConvert.DeserializeObject<ResponseContent>(content);
        }

        public class ResponseContent : IResponseContent
        {
            public ResponseContent(string accessToken, string clientToken, Profile selectedProfile, User user)
            {
                this.AccessToken = accessToken;
                this.ClientToken = clientToken;
                this.SelectedProfile = selectedProfile;
                this.user = user;
            }

            public string AccessToken { get; }
            public string ClientToken { get; }
            public Profile SelectedProfile { get; }
            public User user { get; }
        }
    }
}