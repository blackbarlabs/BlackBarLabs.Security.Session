using System;
using System.Runtime.Serialization;

namespace BlackBarLabs.Security.Session
{
    public interface ISession
    {
        [DataMember]
        Guid Id { get; set; }

        [IgnoreDataMember]
        Guid AuthorizationId { get; set; }

        [DataMember]
        AuthHeaderProps SessionHeader { get; set; }

        [DataMember]
        ICredential Credentials { get; set; }

        [DataMember]
        string RefreshToken { get; set; }
    }
}
