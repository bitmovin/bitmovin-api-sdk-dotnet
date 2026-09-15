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
    /// PccCodecDeviceTypeReach
    /// </summary>
    public class PccCodecDeviceTypeReach
    {
        /// <summary>
        /// DeviceType
        /// </summary>
        [JsonProperty(PropertyName = "deviceType")]
        public string DeviceType { get; set; }

        /// <summary>
        /// Distinct selected device pools that played this codec. (required)
        /// </summary>
        [JsonProperty(PropertyName = "played")]
        public decimal? Played { get; set; }

        /// <summary>
        /// Distinct selected pools that answered about this codec. A protection-only refusal is excluded. (required)
        /// </summary>
        [JsonProperty(PropertyName = "measured")]
        public decimal? Measured { get; set; }
    }
}
