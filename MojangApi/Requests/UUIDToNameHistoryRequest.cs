using System.Net.Http;
using MojangApi.Responses;

namespace MojangApi.Requests
{
    public class UUIDToNameHistoryRequest : Request<UUIDToNameHistoryResponse, UUIDToNameHistoryResponse.ResponseContent>
    {
        public override string RequestUrlString => $"https://api.mojang.com/user/profiles/{UUID}/names";

        public override RequestMethod RequestMethod => RequestMethod.Get;

        public string UUID { get; }

        public UUIDToNameHistoryRequest(string uuid)
        {
            this.UUID = uuid;
        }

        public override void PrepareRequest(HttpClient client)
        {
        }
    }
}