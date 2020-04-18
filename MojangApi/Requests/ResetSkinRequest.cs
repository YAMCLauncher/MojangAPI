namespace MojangApi.Requests
{
    public class ResetSkinRequest : SkinRequest
    {
        public ResetSkinRequest(string accessToken, string uuid) : base(accessToken, uuid)
        {
        }

        public override RequestMethod RequestMethod => RequestMethod.Delete;
    }
}