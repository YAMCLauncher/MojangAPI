namespace MojangApi.Models.Authentication
{
    public class Agent
    {
        public Agent(string name, int version)
        {
            this.Name = name;
            this.Version = version;

        }
        
        public string Name { get; }

        public int Version { get; }
    }
}