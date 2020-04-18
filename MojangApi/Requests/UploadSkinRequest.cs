using System.Net.Http;

namespace MojangApi.Requests
{
    public class UploadSkinRequest : SkinRequest
    {
        public UploadSkinRequest(
            string accessToken,
            string uuid,
            SkinModel model,
            byte[] file,
            string filename
        ) : base(accessToken, uuid)
        {
            Model = model;
            File = file;
            Filename = filename;
        }

        public override RequestMethod RequestMethod => throw new System.NotImplementedException();

        public SkinModel Model { get; }
        public byte[] File { get; }
        public string Filename { get; }
        public string ContentType { get; }

        public override void PrepareRequest(HttpClient client)
        {
            base.PrepareRequest(client);

            var multiple = new MultipartFormDataContent();
            multiple.Add(new StringContent(Model == SkinModel.Default ? "" : "slim"), "model");
            multiple.Add(new ByteArrayContent(File), "file", Filename);

            RequestContent = multiple;
        }
    }
}