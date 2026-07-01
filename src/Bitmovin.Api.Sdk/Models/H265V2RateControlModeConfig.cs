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
    /// Rate control mode configuration. Use H265V2PerceptualQualityModeConfig for PQP mode or H265V2ConstantBitrateModeConfig for CBR mode.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(H265V2PerceptualQualityModeConfig), "PERCEPTUAL_QUALITY_MODE")]
    [JsonSubtypes.KnownSubType(typeof(H265V2ConstantBitrateModeConfig), "CONSTANT_BITRATE_MODE")]

    public class H265V2RateControlModeConfig
    {
        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public H265V2RateControlModeConfigType? Type { get; set; }
    }
}
