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
    /// ErrorRetryHint
    /// </summary>
    public enum ErrorRetryHint
    {
        /// <summary>
        /// RETRY
        /// </summary>
        [EnumMember(Value = "RETRY")]
        RETRY,
        
        /// <summary>
        /// NORETRY
        /// </summary>
        [EnumMember(Value = "NO_RETRY")]
        NORETRY,
        
        /// <summary>
        /// RETRYINDIFFERENTREGION
        /// </summary>
        [EnumMember(Value = "RETRY_IN_DIFFERENT_REGION")]
        RETRYINDIFFERENTREGION
        
    }

}
