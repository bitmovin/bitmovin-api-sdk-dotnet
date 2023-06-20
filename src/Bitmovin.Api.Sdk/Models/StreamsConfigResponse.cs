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
    /// StreamsConfigResponse
    /// </summary>
    public class StreamsConfigResponse
    {
        /// <summary>
        /// The identifier of the stream config
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; internal set; }

        /// <summary>
        /// UUID of the associated organization
        /// </summary>
        [JsonProperty(PropertyName = "orgId")]
        public string OrgId { get; set; }

        /// <summary>
        /// PlayerStyle
        /// </summary>
        [JsonProperty(PropertyName = "playerStyle")]
        public StreamsConfigPlayerStyle PlayerStyle { get; set; }

        /// <summary>
        /// URL of the watermark image
        /// </summary>
        [JsonProperty(PropertyName = "watermarkUrl")]
        public string WatermarkUrl { get; set; }

        /// <summary>
        /// Target link of the watermark image
        /// </summary>
        [JsonProperty(PropertyName = "watermarkTargetLink")]
        public string WatermarkTargetLink { get; set; }
    }
}
