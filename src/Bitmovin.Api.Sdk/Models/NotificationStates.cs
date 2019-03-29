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
    /// NotificationStates
    /// </summary>
    public enum NotificationStates
    {
        /// <summary>
        /// The Notification is fired
        /// </summary>
        [EnumMember(Value = "FIRED")]
        FIRED,
        
        /// <summary>
        /// The Notification is resolved
        /// </summary>
        [EnumMember(Value = "RESOLVED")]
        RESOLVED
        
    }

}
