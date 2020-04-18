using System.Text;
using System.Net.Http;
using MojangApi.Responses;
using Newtonsoft.Json;

namespace MojangApi.Requests.Authentication
{
    public abstract class Request<T, K> : Requests.Request<T, K>
        where T : Responses.Response<K>
        where K : IResponseContent
    {
        protected static JsonSerializerSettings jsonSerializerSettings =  new JsonSerializerSettings
            {
                ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
            };

        public abstract string AuthenticationEndpoint { get; }

        public override string RequestUrlString => $"https://authserver.mojang.com/{AuthenticationEndpoint}";

        public override RequestMethod RequestMethod => RequestMethod.Post;

        public override void PrepareRequest(HttpClient client)
        {
            RequestContent = new StringContent(AuthenticationPayload(), Encoding.UTF8, "application/json");
        }

        public abstract string AuthenticationPayload();
    }
}