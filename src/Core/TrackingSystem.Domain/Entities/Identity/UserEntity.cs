﻿using Microsoft.AspNetCore.Identity;
using TrackingSystem.Domain.Enums;
using TrackingSystem.Shared.Enums;

namespace TrackingSystem.Domain.Entities.Identity
{
    public sealed class UserEntity : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public String Name { get; set; } = String.Empty;
        public string FilePath { get; set; } = String.Empty;
        public UserRegisterSource RegisterSource { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public Domain.Enums.Language Language { get; set; }
        public Theme Theme { get; set; }
        public Profile ProfileType { get; set; }
        public ICollection<UserPermissionEntity> UserPermissions { get; set; }

    }
}
