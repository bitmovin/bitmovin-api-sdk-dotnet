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
    /// TimeBasedTrimmingInputStream
    /// </summary>
    public class TimeBasedTrimmingInputStream : InputStream
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "TRIMMING_TIME_BASED";
#pragma warning restore CS0414

        /// <summary>
        /// The id of the ingest input stream that should be trimmed
        /// </summary>
        [JsonProperty(PropertyName = "inputStreamId")]
        public string InputStreamId { get; set; }

        /// <summary>
        /// Defines the offset in seconds at which the encoding should start, beginning at 0. The frame indicated by this value will be included in the encoding
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public double? Offset { get; set; }

        /// <summary>
        /// Defines how many seconds of the input will be encoded. Not defining or setting it to null indicates that the remaining input (considering offset) will be encoded.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; set; }
    }
}
