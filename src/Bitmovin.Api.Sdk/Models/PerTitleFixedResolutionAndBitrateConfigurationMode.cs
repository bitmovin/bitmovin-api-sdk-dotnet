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
    /// PerTitleFixedResolutionAndBitrateConfigurationMode
    /// </summary>
    public enum PerTitleFixedResolutionAndBitrateConfigurationMode
    {
        /// <summary>
        /// The next bitrate for the forced representation is the calculated bitrate of the Per-Title representation multiplied by the factor.
        /// </summary>
        [EnumMember(Value = "LAST_CALCULATED_BITRATE")]
        LAST_CALCULATED_BITRATE,
        
        /// <summary>
        /// The next bitrate for the forced representation is the minimum bitrate defined in the Per-Title template stream multiplied by the factor.
        /// </summary>
        [EnumMember(Value = "MINIMUM")]
        MINIMUM,
        
        /// <summary>
        /// The next bitrate for the forced representation is the maximum bitrate defined in the Per-Title template stream multiplied by the factor.
        /// </summary>
        [EnumMember(Value = "MAXIMUM")]
        MAXIMUM,
        
        /// <summary>
        /// The next bitrate for the forced representation is the average bitrate defined in the Per-Title template stream multiplied by the factor.
        /// </summary>
        [EnumMember(Value = "AVERAGE")]
        AVERAGE
        
    }

}
