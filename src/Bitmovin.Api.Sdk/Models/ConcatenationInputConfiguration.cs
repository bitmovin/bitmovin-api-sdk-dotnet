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
    /// ConcatenationInputConfiguration
    /// </summary>
    public class ConcatenationInputConfiguration
    {
        /// <summary>
        /// The ID of the input stream to be concatenated. This can be an ingest input stream or a trimming input stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputStreamId")]
        public string InputStreamId { get; set; }

        /// <summary>
        /// Exactly one input stream of a concatenation must have this set to true, which will be used as reference for scaling, aspect ratio, FPS, sample rate, etc. 
        /// </summary>
        [JsonProperty(PropertyName = "isMain")]
        public bool? IsMain { get; set; }

        /// <summary>
        /// A unique integer value that determines concatenation order (required)
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public int? Position { get; set; }

        /// <summary>
        /// Inserts a padding sequence (black frames and/or silent audio) before the input stream.
        /// </summary>
        [JsonProperty(PropertyName = "paddingBefore")]
        public PaddingSequence PaddingBefore { get; set; }

        /// <summary>
        /// Inserts a padding sequence (black frames and/or silent audio) after the input stream.
        /// </summary>
        [JsonProperty(PropertyName = "paddingAfter")]
        public PaddingSequence PaddingAfter { get; set; }

        /// <summary>
        /// Specifies the aspect mode that is used when adapting to the main input stream&#39;s aspect ratio
        /// </summary>
        [JsonProperty(PropertyName = "aspectMode")]
        public AspectMode? AspectMode { get; set; }
    }
}
