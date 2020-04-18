using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using MojangApi.Models;
using System.Collections;

namespace MojangApi.Responses
{
    public class PlayernamesToUUIDsResponse : Response<PlayernamesToUUIDsResponse.ResponseContent>
    {
        public IReadOnlyCollection<PlayerUUID> PlayerUUIDs { get; private set; }

        public PlayernamesToUUIDsResponse(HttpResponseMessage message, string content) : base(message, content)
        {
        }

        protected override void Parse(HttpResponseMessage message, string content)
        {
            Content = new ResponseContent(JsonConvert.DeserializeObject<List<PlayerUUID>>(content));
        }

        public class ResponseContent : IResponseContent, IReadOnlyCollection<PlayerUUID>
        {
            private readonly IList<PlayerUUID> list;

            public int Count => list.Count;

            public ResponseContent(IList<PlayerUUID> list)
            {
                this.list = list;
            }

            public IEnumerator<PlayerUUID> GetEnumerator()
            {
                return list.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}