using System.Linq;
using System.Net.Http;
using System.Collections;
using System.Collections.Generic;

namespace MojangApi.Responses
{
    public class StatusResponse : Response<StatusResponse.ResponseContent>
    { 
        public StatusResponse(HttpResponseMessage message, string content) : base(message, content)
        {
        }

        protected override void Parse(HttpResponseMessage message, string content)
        {
            Content = new ResponseContent(Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, Status>>>(content));
        }

        public enum Status
        {
            Green,
            Yellow,
            Red
        }

        public class ResponseContent :
            IResponseContent,
            IReadOnlyCollection<KeyValuePair<string, StatusResponse.Status>>
        {
            private Dictionary<string, Status> statusDict = new Dictionary<string, Status>();

            public int Count => statusDict.Count;

            public ResponseContent(List<Dictionary<string, Status>> dicts)
            {
                foreach (var dict in dicts)
                {
                    foreach (var item in dict)
                    {
                        statusDict.Add(item.Key, item.Value);
                    }
                }
            }

            public IEnumerator<KeyValuePair<string, Status>> GetEnumerator()
            {
                return statusDict.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public Status? this[string name]
            {
                get => statusDict.FirstOrDefault(p => p.Key == name).Value;
            }

        }
    }
}