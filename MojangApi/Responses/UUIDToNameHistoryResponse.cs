using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections;

namespace MojangApi.Responses
{
    public class UUIDToNameHistoryResponse : Response<UUIDToNameHistoryResponse.ResponseContent>
    {
        public UUIDToNameHistoryResponse(HttpResponseMessage message, string content) : base(message, content)
        {
        }

        protected override void Parse(HttpResponseMessage message, string content)
        {
            Content = new ResponseContent(JsonConvert.DeserializeObject<List<History>>(content));
        }

        public class History
        {
            public string Name { get; set; }
            public long? ChangedToAt { get; set; }

            public History(string name, long? changedToAt)
            {
                this.Name = name;
                this.ChangedToAt = changedToAt;
            }
        }

        public class ResponseContent : ReadOnlyCollection<History>, IResponseContent
        {
            public ResponseContent(IList<History> list) : base(list)
            {
            }
        }
    }
}