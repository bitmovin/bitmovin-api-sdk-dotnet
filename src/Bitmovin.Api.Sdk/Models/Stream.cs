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
    /// Stream
    /// </summary>

    public class Stream : BitmovinResource
    {
        /// <summary>
        /// InputStreams
        /// </summary>
        [JsonProperty(PropertyName = "inputStreams")]
        public List<StreamInput> InputStreams { get; set; } = new List<StreamInput>();
        
        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; set; } = new List<EncodingOutput>();
        
        /// <summary>
        /// Set true to create quality metadata for this stream
        /// </summary>
        [JsonProperty(PropertyName = "createQualityMetaData")]
        public bool? CreateQualityMetaData { get; set; }
        
        /// <summary>
        /// Id of the codec configuration (required)
        /// </summary>
        [JsonProperty(PropertyName = "codecConfigId")]
        public string CodecConfigId { get; set; }
        
        /// <summary>
        /// Number of encoded segments. Available after encoding finishes.
        /// </summary>
        [JsonProperty(PropertyName = "segmentsEncoded")]
        public int? SegmentsEncoded { get; set; }
        
        /// <summary>
        /// Conditions to evaluate before creating the stream. If this evaluation fails, the stream won&#39;t be created. All muxings that depend on the stream will also not be created.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public AbstractCondition Conditions { get; set; }
        
        /// <summary>
        /// If this is set and contains objects, then this stream has been ignored during the encoding process
        /// </summary>
        [JsonProperty(PropertyName = "ignoredBy")]
        public List<Ignoring> IgnoredBy { get; set; } = new List<Ignoring>();
        
        /// <summary>
        /// Mode of the stream
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public StreamMode? Mode { get; set; }
        
        /// <summary>
        /// Settings to configure Per-Title on stream level
        /// </summary>
        [JsonProperty(PropertyName = "perTitleSettings")]
        public StreamPerTitleSettings PerTitleSettings { get; set; }
        
        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public StreamMetadata Metadata { get; set; }
        
        /// <summary>
        /// Determines how to react to errors during decoding
        /// </summary>
        [JsonProperty(PropertyName = "decodingErrorMode")]
        public DecodingErrorMode? DecodingErrorMode { get; set; }
        
        /// <summary>
        /// Contains stream properties which may not have been defined in the configuration
        /// </summary>
        [JsonProperty(PropertyName = "appliedSettings")]
        public AppliedStreamSettings AppliedSettings { get; internal set; }
    }

}
