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
    /// StaticRtmpIngestPoint
    /// </summary>
    public class StaticRtmpIngestPoint
    {
        /// <summary>
        /// The ID of the created static rtmp ingest point 
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the ingest point. This can be helpful for easier identifying your ingest points 
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// StreamKeyConfiguration
        /// </summary>
        [JsonProperty(PropertyName = "streamKeyConfiguration")]
        public StreamKeyConfiguration StreamKeyConfiguration { get; set; }
    }
}
