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
    /// H265V2ConstantBitrateModeConfig
    /// </summary>
    public class H265V2ConstantBitrateModeConfig : H265V2RateControlModeConfig
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "CONSTANT_BITRATE_MODE";
#pragma warning restore CS0414

        /// <summary>
        /// Enable filler data for constant bitrate mode.
        /// </summary>
        [JsonProperty(PropertyName = "fillerdata")]
        public bool? Fillerdata { get; set; }
    }
}
