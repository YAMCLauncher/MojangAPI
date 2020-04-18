using System.Net.Http;
using MojangApi.Requests.Authentication;
using MojangApi.Responses;

namespace MojangApi.Requests
{
    public class UsernameToUUIDRequest : Request<UsernameToUUIDResponse, UsernameToUUIDResponse.ResponseContent>
    {
        public override string RequestUrlString
        {
            get
            {
                var s = $"https://api.mojang.com/users/profiles/minecraft/{Username}";
                if (TimeStamp != null)
                {
                    s += $"?at={TimeStamp}";
                }
                return s;
            }
        }

        public override RequestMethod RequestMethod => RequestMethod.Get;

        public string Username { get; }

        public long? TimeStamp { get; } = null;

        public UsernameToUUIDRequest(string username, long? timestamp = null)
        {
            this.Username = username;
            this.TimeStamp = timestamp;
        }

        public override void PrepareRequest(HttpClient client)
        {
        }
    }
}