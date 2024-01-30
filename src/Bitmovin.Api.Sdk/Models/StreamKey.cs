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
    /// StreamKey
    /// </summary>
    public class StreamKey : BitmovinResource
    {
        /// <summary>
        /// Stream key used for live streaming. This stream key is reserved and can be re-used with different live encodings. If this value is not provided, a unique random stream key will be generated. **Important:** This value has to be globally unique. If it is set manually, be sure to use a secure value. If the stream key value is guessed by others your live encoding can be compromised. 
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Status of the stream key
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public StreamKeyStatus? Status { get; internal set; }

        /// <summary>
        /// Type of the stream key
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public StreamKeyType? Type { get; internal set; }

        /// <summary>
        /// ID of the encoding that is assigned to this stream key. Not set if status is UNASSIGNED
        /// </summary>
        [JsonProperty(PropertyName = "assignedEncodingId")]
        public string AssignedEncodingId { get; internal set; }

        /// <summary>
        /// ID of the ingest point that is assigned to this stream key. Not set if status is UNASSIGNED
        /// </summary>
        [JsonProperty(PropertyName = "assignedIngestPointId")]
        public string AssignedIngestPointId { get; internal set; }
    }
}
