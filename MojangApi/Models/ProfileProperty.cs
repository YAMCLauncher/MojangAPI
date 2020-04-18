namespace MojangApi.Models
{
    public class ProfileProperty
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Signature { get; set; }

        public ProfileProperty(string name, string value, string signature)
        {
            this.Name = name;
            this.Value = value;
            this.Signature = signature;
        }
    }
}