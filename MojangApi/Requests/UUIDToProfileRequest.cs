using System.Net.Http;
using MojangApi.Responses;

namespace MojangApi.Requests
{
    public class UUIDToProfileRequest : Request<UUIDToProfileResponse, UUIDToProfileResponse.ResponseContent>
    {
        public override string RequestUrlString
        {
            get
            {
                var s = $"https://sessionserver.mojang.com/session/minecraft/profile/{UUID}";
                if (Unsigned == false)
                {
                    s += "?unsigned=false";
                }
                return s;
            }
        }

        public override RequestMethod RequestMethod => RequestMethod.Get;

        public string UUID { get; }

        public bool Unsigned { get; }

        public UUIDToProfileRequest(string uuid, bool unsigned = true)
        {
            this.UUID = uuid;
            this.Unsigned = unsigned;
        }

        public override void PrepareRequest(HttpClient client)
        {
        }
    }
}