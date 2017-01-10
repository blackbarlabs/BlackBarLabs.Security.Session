using System;
using System.Runtime.Serialization;

using BlackBarLabs.Api.Resources;

namespace BlackBarLabs.Security.Session
{
    public interface IAuthorization
    {
        [DataMember]
        WebId Id { get; set; }

        [DataMember]
        Uri[] CredentialProviders { get; set; }
    }
}
