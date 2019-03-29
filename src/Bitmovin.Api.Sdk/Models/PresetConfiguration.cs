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
    /// PresetConfiguration
    /// </summary>
    public enum PresetConfiguration
    {
        /// <summary>
        /// LIVE_HIGH_QUALITY
        /// </summary>
        [EnumMember(Value = "LIVE_HIGH_QUALITY")]
        LIVE_HIGH_QUALITY,
        
        /// <summary>
        /// LIVE_LOW_LATENCY
        /// </summary>
        [EnumMember(Value = "LIVE_LOW_LATENCY")]
        LIVE_LOW_LATENCY,
        
        /// <summary>
        /// VOD_HIGH_QUALITY
        /// </summary>
        [EnumMember(Value = "VOD_HIGH_QUALITY")]
        VOD_HIGH_QUALITY,
        
        /// <summary>
        /// VOD_HIGH_SPEED
        /// </summary>
        [EnumMember(Value = "VOD_HIGH_SPEED")]
        VOD_HIGH_SPEED
        
    }

}
