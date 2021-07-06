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
    /// DolbyDigitalDynamicRangeCompression
    /// </summary>
    public class DolbyDigitalDynamicRangeCompression
    {
        /// <summary>
        /// Line mode is intended for use in products providing line‐level or speaker‐level outputs, and is applicable to the widest range of products. Products such as set‐top boxes, DVD players, DTVs, A/V surround decoders, and outboard Dolby Digital decoders typically use this mode.
        /// </summary>
        [JsonProperty(PropertyName = "lineMode")]
        public DolbyDigitalDynamicRangeCompressionMode? LineMode { get; set; }

        /// <summary>
        /// RF mode is intended for products such as a low‐cost television receivers.
        /// </summary>
        [JsonProperty(PropertyName = "rfMode")]
        public DolbyDigitalDynamicRangeCompressionMode? RfMode { get; set; }
    }
}
