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
        /// Determines the input source(s) for the stream. All video streams of an encoding need to have identical input configurations (required)
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
        public int? SegmentsEncoded { get; internal set; }

        /// <summary>
        /// Defines a condition that is evaluated against the input of the Stream. If the condition is not fulfilled, the Stream will be ignored during the encoding process. The &#39;streamConditionMode&#39; of a Muxing allows to control how ignored Streams affect the Muxing. When retrieving the resource after the analysis step of the encoding has finished, &#39;ignoredBy&#39; will indicate if and why it has been ignored. See [Stream Conditions](https://bitmovin.com/docs/encoding/articles/stream-conditions) for more information
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public AbstractCondition Conditions { get; set; }

        /// <summary>
        /// This read-only property is set during the analysis step of the encoding. If it contains items, the Stream has been ignored during the encoding process due to its &#39;conditions&#39;
        /// </summary>
        [JsonProperty(PropertyName = "ignoredBy")]
        public List<Ignoring> IgnoredBy { get; internal set; } = new List<Ignoring>();

        /// <summary>
        /// Mode of the stream
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public StreamMode? Mode { get; set; }

        /// <summary>
        /// The encoding mode of the stream which was applied by the assigned codec configuration
        /// </summary>
        [JsonProperty(PropertyName = "selectedEncodingMode")]
        public EncodingMode? SelectedEncodingMode { get; internal set; }

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
