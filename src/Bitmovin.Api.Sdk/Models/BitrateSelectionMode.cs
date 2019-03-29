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
    /// BitrateSelectionMode
    /// </summary>
    public enum BitrateSelectionMode
    {
        /// <summary>
        /// Bitrate will be selected to provide the best quality for the resulting encoding profile.
        /// </summary>
        [EnumMember(Value = "OPTIMIZED")]
        OPTIMIZED,
        
        /// <summary>
        /// Bitrate will be selected based on the complexity range given in the configuration (&#x60;lowComplexityBoundaryForMaxBitrate&#x60; and &#x60;highComplexityBoundaryForMaxBitrate&#x60;). Complexity is defined by the max bitrate selected for the resulting encoding profile.
        /// </summary>
        [EnumMember(Value = "COMPLEXITY_RANGE")]
        COMPLEXITY_RANGE
        
    }

}
