namespace MojangApi.Models
{
    public class PlayerUUID
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public bool Legacy { get; private set; }
        public bool Demo { get; private set; }

        public PlayerUUID(string id, string name, bool? legacy, bool? demo)
        {
            this.Id = id;
            this.Name = name;
            this.Legacy = legacy ?? false;
            this.Demo = demo ?? false;
        }
    }
}