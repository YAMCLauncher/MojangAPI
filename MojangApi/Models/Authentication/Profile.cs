namespace MojangApi.Models.Authentication
{
    public class Profile
    {
        public Profile(
            string agent,
            string id,
            string name,
            string userId,
            long createdAt,
            bool legacyProfile,
            bool suspended,
            bool paid,
            bool migrated,
            bool? legacy
        )
        {
            Agent = agent;
            Id = id;
            Name = name;
            UserId = userId;
            CreatedAt = createdAt;
            LegacyProfile = legacyProfile;
            Suspended = suspended;
            Paid = paid;
            Migrated = migrated;
            Legacy = legacy ?? false;
        }

        public string Agent { get; }
        public string Id { get; }
        public string Name { get; }
        public string UserId { get; }
        public long CreatedAt { get; }
        public bool LegacyProfile { get; }
        public bool Suspended { get; }
        public bool Paid { get; }
        public bool Migrated { get; }
        public bool Legacy { get; }
    }
}