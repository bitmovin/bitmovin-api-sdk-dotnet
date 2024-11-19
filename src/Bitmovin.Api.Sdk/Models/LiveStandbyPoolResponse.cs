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
    /// LiveStandbyPoolResponse
    /// </summary>
    public class LiveStandbyPoolResponse : BitmovinResource
    {
        /// <summary>
        /// Number of instances to keep ready for streaming while the pool is running (required)
        /// </summary>
        [JsonProperty(PropertyName = "targetPoolSize")]
        public int? TargetPoolSize { get; internal set; }

        /// <summary>
        /// Number of instances currently in ready state in the pool
        /// </summary>
        [JsonProperty(PropertyName = "readyEncodings")]
        public int? ReadyEncodings { get; internal set; }

        /// <summary>
        /// Number of instances currently being prepared in the pool
        /// </summary>
        [JsonProperty(PropertyName = "preparingEncodings")]
        public int? PreparingEncodings { get; internal set; }

        /// <summary>
        /// Number of instances currently in error state in the pool
        /// </summary>
        [JsonProperty(PropertyName = "errorEncodings")]
        public int? ErrorEncodings { get; internal set; }

        /// <summary>
        /// The name of the encoding template used with this Standby Pool
        /// </summary>
        [JsonProperty(PropertyName = "encodingTemplateName")]
        public string EncodingTemplateName { get; set; }

        /// <summary>
        /// PoolStatus
        /// </summary>
        [JsonProperty(PropertyName = "poolStatus")]
        public LiveStandbyPoolStatus? PoolStatus { get; set; }
    }
}
