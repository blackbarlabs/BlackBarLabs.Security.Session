using System;
using System.Runtime.Serialization;

namespace BlackBarLabs.Security.Session
{
    public interface IAuthorization
    {
        [DataMember]
        Guid Id { get; set; }

        [DataMember]
        Uri[] CredentialProviders { get; set; }
    }
}
