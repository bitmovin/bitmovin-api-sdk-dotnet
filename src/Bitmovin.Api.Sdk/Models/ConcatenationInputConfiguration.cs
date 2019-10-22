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
        /// The id of the input stream that should be used for concatenation. Can be either an ingest input stream, or the result of a trimming input stream
        /// </summary>
        [JsonProperty(PropertyName = "inputStreamId")]
        public string InputStreamId { get; set; }
        
        /// <summary>
        /// Exactly one input stream of a concatenation must have this set to true, which will be used as reference for scaling, aspect ratio, FPS, sample rate, etc. 
        /// </summary>
        [JsonProperty(PropertyName = "isMain")]
        public bool? IsMain { get; set; }
        
        /// <summary>
        /// Position of the stream
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public int? Position { get; set; }
        
        /// <summary>
        /// Inserts a padding sequence (black frames and/or silent audio) before the input stream. If this is set, all video output streams of the encoding need to use the same ConcatenationInputStream.
        /// </summary>
        [JsonProperty(PropertyName = "paddingBefore")]
        public PaddingSequence PaddingBefore { get; set; }
        
        /// <summary>
        /// Inserts a padding sequence (black frames and/or silent audio) after the input stream. If this is set, all video output streams of the encoding need to use the same ConcatenationInputStream.
        /// </summary>
        [JsonProperty(PropertyName = "paddingAfter")]
        public PaddingSequence PaddingAfter { get; set; }
    }

}
