using System.Net.Http;
using MojangApi.Responses;

namespace MojangApi.Requests
{
    public abstract class Request<T, K> where T : Response<K> where K : IResponseContent
    {
        public abstract string RequestUrlString { get;  }

        public abstract RequestMethod RequestMethod { get; }

        public HttpContent RequestContent { get; protected set; }

        public abstract void PrepareRequest(HttpClient client);
    }
}
