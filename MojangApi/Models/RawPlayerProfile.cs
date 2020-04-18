using System.Collections.Generic;

namespace MojangApi.Models
{
    public class RawPlayerProfile
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public bool Legacy { get; private set; }
        public IReadOnlyCollection<ProfileProperty> Properties { get; private set; }

        public RawPlayerProfile(string id, string name, bool? legacy, List<ProfileProperty> properties)
        {
            this.Id = id;
            this.Name = name;
            this.Properties = properties.AsReadOnly();
        }
    }
}