using System.Text;
using System;
using System.Linq;
using Newtonsoft.Json;

namespace MojangApi.Models
{
    public class PlayerProfile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Legacy { get; set; }
        public ProfileTextures Textures { get; set; }

        public PlayerProfile(RawPlayerProfile rawProfile)
        {
            this.Id = rawProfile.Id;
            this.Name = rawProfile.Name;
            this.Legacy = rawProfile.Legacy;
            if (rawProfile.Properties.Count != 0)
            {
                var property = rawProfile.Properties.FirstOrDefault(p => p.Name == "textures");
                if (property != null)
                {
                    Textures = JsonConvert.DeserializeObject<ProfileTextures>(
                        Encoding.ASCII.GetString(Convert.FromBase64String(property.Value))
                    );
                }
            }
        }
    }
}