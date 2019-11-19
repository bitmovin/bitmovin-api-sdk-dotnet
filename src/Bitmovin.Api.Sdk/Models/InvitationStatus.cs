using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JsonSubTypes;
using Newtonsoft.Json;

using Bitmovin.Api.Sdk.Common;
using Bitmovin.Api.Sdk.Models;

namespace Bitmovin.Api.Sdk.Models
{
    /// <summary>
    /// InvitationStatus
    /// </summary>
    public enum InvitationStatus
    {
        /// <summary>
        /// Pending status of the invitation
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Accepted status of the invitation
        /// </summary>
        [EnumMember(Value = "ACCEPTED")]
        ACCEPTED
        
    }

}
