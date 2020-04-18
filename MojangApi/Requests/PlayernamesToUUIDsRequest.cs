using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using MojangApi.Responses;

namespace MojangApi.Requests
{
    public class PlayernamesToUUIDsRequest : Request<PlayernamesToUUIDsResponse, PlayernamesToUUIDsResponse.ResponseContent>
    {
        public IReadOnlyCollection<string> Playernames { get; }

        public override string RequestUrlString => "https://api.mojang.com/profiles/minecraft";

        public override RequestMethod RequestMethod => RequestMethod.Post;

        public PlayernamesToUUIDsRequest(IEnumerable<string> playernames)
        {
            Playernames = new List<string>(playernames).AsReadOnly();
        }

        public override void PrepareRequest(HttpClient client)
        {
            string json = JsonConvert.SerializeObject(Playernames);
            RequestContent = new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}