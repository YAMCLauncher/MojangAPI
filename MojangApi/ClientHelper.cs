using System.Net.Http;
using System;
using MojangApi.Requests;
using MojangApi.Responses;
using System.Threading.Tasks;

namespace MojangApi
{
    public static class ClientHelper
    {
        public static async Task<HttpResponseMessage> RequestRawAsync<T, K>(Request<T, K> request)
            where T : Response<K>
            where K : IResponseContent
        {
            HttpClient client = new HttpClient();

            request.PrepareRequest(client);
            
            HttpResponseMessage resp = null;

            switch (request.RequestMethod)
            {
                case RequestMethod.Get:
                    resp = await client.GetAsync(request.RequestUrlString);
                    break;
                case RequestMethod.Post:
                    resp = await client.PostAsync(request.RequestUrlString, request.RequestContent);
                    break;
                case RequestMethod.Put:
                    resp = await client.PutAsync(request.RequestUrlString, request.RequestContent);
                    break;
                case RequestMethod.Delete:
                    resp = await client.DeleteAsync(request.RequestUrlString);
                    break;
            }

            return resp;
        }

        public static async Task<T> RequestAsync<T, K>(Request<T, K> request)
            where T : Response<K>
            where K : IResponseContent
        {
            var resp = await RequestRawAsync(request);
            return await Response<K>.CreateInstanceAsync<T>(resp);
        }
    }
}
