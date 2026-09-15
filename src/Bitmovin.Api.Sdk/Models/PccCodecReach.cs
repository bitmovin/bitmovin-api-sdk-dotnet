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
    /// PccCodecReach
    /// </summary>
    public class PccCodecReach
    {
        /// <summary>
        /// Codec
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; set; }

        /// <summary>
        /// ByDeviceType
        /// </summary>
        [JsonProperty(PropertyName = "byDeviceType")]
        public List<PccCodecDeviceTypeReach> ByDeviceType { get; set; } = new List<PccCodecDeviceTypeReach>();
    }
}
