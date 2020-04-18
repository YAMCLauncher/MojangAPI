using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MojangApi.Responses
{
    public abstract partial class Response<K> where K : IResponseContent
    {
        public bool IsSuccess { get; protected set; }

        public HttpStatusCode StatusCode { get; }

        public ErrorResponse Error { get; } = null;

        public K Content { get; protected set; } = default(K);

        protected Response(HttpResponseMessage message, string content)
        {
            this.IsSuccess = message.IsSuccessStatusCode;
            this.StatusCode = message.StatusCode;

            if (!this.IsSuccess)
            {
                Error = JsonConvert.DeserializeObject<ErrorResponse>(content);
            }
            else
            {
                Parse(message, content);
            }
        }

        public static async Task<T> CreateInstanceAsync<T>(HttpResponseMessage message) where T : Response<K>
        {
            if (message == null)
            {
                return null;
            }

            string content = await message.Content.ReadAsStringAsync();

            return Activator.CreateInstance(typeof(T), new object[] { message, content }) as T;
        }

        protected abstract void Parse(HttpResponseMessage message, string content);
    }
}
