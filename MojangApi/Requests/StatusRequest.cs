using System.Net.Http;
using MojangApi.Responses;

namespace MojangApi.Requests
{
    public class StatusRequest : Request<StatusResponse, StatusResponse.ResponseContent>
    {
        public override string RequestUrlString => "https://status.mojang.com/check";

        public override RequestMethod RequestMethod => RequestMethod.Get;

        public override void PrepareRequest(HttpClient client)
        {
        }
    }
}