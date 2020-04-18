using System.Collections.Generic;

namespace MojangApi.Models.Authentication
{
    public class User
    {
        public User(
            string id,
            string email,
            string username,
            string registerIp,
            string migratedFrom,
            long migratedAt,
            long registeredAt,
            long passwordChangedAt,
            long dateOfBirth,
            bool suspended,
            bool blocked,
            bool secured,
            bool migrated,
            bool emailVerified,
            bool legacyUser,
            bool verifiedByParent,
            List<Property> properties
        )
        {
            Id = id;
            Email = email;
            Username = username;
            RegisterIp = registerIp;
            MigratedFrom = migratedFrom;
            MigratedAt = migratedAt;
            RegisteredAt = registeredAt;
            PasswordChangedAt = passwordChangedAt;
            DateOfBirth = dateOfBirth;
            Suspended = suspended;
            Blocked = blocked;
            Secured = secured;
            Migrated = migrated;
            EmailVerified = emailVerified;
            LegacyUser = legacyUser;
            VerifiedByParent = verifiedByParent;
            Properties = properties.AsReadOnly();
        }

        public string Id { get; }
        public string Email { get; }
        public string Username { get; }
        public string RegisterIp { get; }
        public string MigratedFrom { get; }
        public long MigratedAt { get; }
        public long RegisteredAt { get; }
        public long PasswordChangedAt { get; }
        public long DateOfBirth { get; }
        public bool Suspended { get; }
        public bool Blocked { get; }
        public bool Secured { get; }
        public bool Migrated { get; }
        public bool EmailVerified { get; }
        public bool LegacyUser { get; }
        public bool VerifiedByParent { get; }
        public IReadOnlyCollection<Property> Properties { get; }

        public class Property
        {
            public Property(
                string name,
                string value
            )
            {
                Name = name;
                Value = value;
            }

            public string Name { get; }
            public string Value { get; }
        }
    }
}