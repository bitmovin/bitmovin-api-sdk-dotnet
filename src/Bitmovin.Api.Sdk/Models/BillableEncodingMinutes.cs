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
    /// BillableEncodingMinutes
    /// </summary>
    public class BillableEncodingMinutes
    {
        /// <summary>
        /// EncodingMode
        /// </summary>
        [JsonProperty(PropertyName = "encodingMode")]
        public EncodingMode? EncodingMode { get; set; }

        /// <summary>
        /// Codec
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public CodecConfigType? Codec { get; set; }

        /// <summary>
        /// PerTitleResultStream
        /// </summary>
        [JsonProperty(PropertyName = "perTitleResultStream")]
        public StatisticsPerTitleStream? PerTitleResultStream { get; set; }

        /// <summary>
        /// PsnrMode
        /// </summary>
        [JsonProperty(PropertyName = "psnrMode")]
        public PsnrPerStreamMode? PsnrMode { get; set; }

        /// <summary>
        /// Name of the preset configuration used for the codec configuration or \&quot;CUSTOM\&quot; if any preset values were overridden
        /// </summary>
        [JsonProperty(PropertyName = "preset")]
        public string Preset { get; internal set; }

        /// <summary>
        /// Indicates if the stream was part of a live encoding.
        /// </summary>
        [JsonProperty(PropertyName = "live")]
        public bool? Live { get; internal set; }

        /// <summary>
        /// Indicates if an enhanced interlace filter was used.
        /// </summary>
        [JsonProperty(PropertyName = "enhancedDeinterlace")]
        public bool? EnhancedDeinterlace { get; internal set; }

        /// <summary>
        /// BillableMinutes
        /// </summary>
        [JsonProperty(PropertyName = "billableMinutes")]
        public BillableEncodingMinutesDetails BillableMinutes { get; set; }
    }
}
