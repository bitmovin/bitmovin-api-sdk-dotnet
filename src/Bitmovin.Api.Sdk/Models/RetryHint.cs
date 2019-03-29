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
    /// RetryHint
    /// </summary>
    public enum RetryHint
    {
        /// <summary>
        /// The process may succeed when retrying
        /// </summary>
        [EnumMember(Value = "RETRY")]
        RETRY,
        
        /// <summary>
        /// The process may succeed when retrying in another region
        /// </summary>
        [EnumMember(Value = "RETRY_IN_DIFFERENT_REGION")]
        RETRY_IN_DIFFERENT_REGION,
        
        /// <summary>
        /// The process is expected to fail on subsequent retries
        /// </summary>
        [EnumMember(Value = "NO_RETRY")]
        NO_RETRY
        
    }

}
