using System.Net.Http;
using MojangApi.Responses;

namespace MojangApi.Requests
{
    public abstract class SkinRequest : Request<SkinResponse, SkinResponse.ResponseContent>
    {
        public string AccessToken { get; }
        public string UUID { get; }

        public override string RequestUrlString => $"https://api.mojang.com/user/profile/{UUID}/skin";

        public SkinRequest(string accessToken, string uuid)
        {
            AccessToken = accessToken;
            UUID = uuid;
        }

        public override void PrepareRequest(HttpClient client)
        {
            client.DefaultRequestHeaders.Add($"Authorization", $"Bearer {AccessToken}");
        }

        public enum SkinModel
        {
            Default,
            Slim
        }
    }
}