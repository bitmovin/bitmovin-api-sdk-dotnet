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
        /// BillableMinutes
        /// </summary>
        [JsonProperty(PropertyName = "billableMinutes")]
        public BillableEncodingMinutesDetails BillableMinutes { get; set; }
    }
}
