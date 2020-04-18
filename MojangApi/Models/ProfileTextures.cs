using System.Collections.Generic;

namespace MojangApi.Models
{
    public class ProfileTextures
    {
        public long TimeStamp { get; private set; }
        public string ProfileId { get; private set; }
        public string ProfileName { get; private set; }
        public bool SignatureRequired { get; private set; }
        public IDictionary<string, Texture> Textures { get; private set; }

        public ProfileTextures(long timestamp, string profileId, string profileName, bool? signatureRequired, IDictionary<string, Texture> textures)
        {
            this.TimeStamp = timestamp;
            this.ProfileId = profileId;
            this.ProfileName = profileName;
            this.SignatureRequired = signatureRequired ?? false;
            this.Textures = textures ?? new Dictionary<string, Texture>();
        }

        public class Texture
        {
            public string Url { get; private set; }

            public Texture(string url)
            {
                this.Url = url;
            }
        }
    }
}