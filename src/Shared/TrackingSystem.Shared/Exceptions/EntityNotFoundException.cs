﻿using TrackingSystem.Shared.Abstract;

namespace TrackingSystem.Shared.Exceptions
{
    public sealed class EntityNotFoundException : BaseAppException
    {
        public override int StatusCodeToRise => 404;
        public EntityNotFoundException(string entityName, int entityIdentifier) : base($"Entity {entityName} with Id : {entityIdentifier} doesnt exists") { }
        public EntityNotFoundException(string entityName, Guid entityIdentifier) : base($"Entity {entityName} with Id : {entityIdentifier} doesnt exist") { }
        public EntityNotFoundException(string message) : base(message) { }
        public EntityNotFoundException(Dictionary<string, string[]> errors) : base(errors) { }
    }
}
