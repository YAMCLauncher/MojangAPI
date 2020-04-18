using System.Collections.Generic;
using System.Net.Http;

namespace MojangApi.Requests
{
    public class ChangeSkinRequest : SkinRequest
    {
        public ChangeSkinRequest(
            string accessToken,
            string uuid,
            SkinModel model,
            string url
        ) : base(accessToken, uuid)
        {
            Model = model;
            Url = url;
        }

        public override RequestMethod RequestMethod => RequestMethod.Post;

        public SkinModel Model { get; }
        public string Url { get; }

        public override void PrepareRequest(HttpClient client)
        {
            base.PrepareRequest(client);
            
            RequestContent = new FormUrlEncodedContent(new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("model", Model == SkinModel.Default ? "" : "slim"),
                new KeyValuePair<string, string>("url", Url)
            });
        }
    }
}