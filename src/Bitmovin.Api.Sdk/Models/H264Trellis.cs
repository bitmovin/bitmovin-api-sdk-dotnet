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
    /// H264Trellis
    /// </summary>
    public enum H264Trellis
    {
        /// <summary>
        /// Disabled
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED,
        
        /// <summary>
        /// Enabled only on the final encode of a macro block
        /// </summary>
        [EnumMember(Value = "ENABLED_FINAL_MB")]
        ENABLED_FINAL_MB,
        
        /// <summary>
        /// Enabled on all mode decisions
        /// </summary>
        [EnumMember(Value = "ENABLED_ALL")]
        ENABLED_ALL
        
    }

}
