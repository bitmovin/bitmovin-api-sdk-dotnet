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
    /// BitmovinResource
    /// </summary>
    public class BitmovinResource : BitmovinResponse
    {
        /// <summary>
        /// Name of the resource. Can be freely chosen by the user.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the resource. Can be freely chosen by the user.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Creation timestamp formatted in UTC: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Modified timestamp formatted in UTC: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "modifiedAt")]
        public DateTime? ModifiedAt { get; internal set; }

        /// <summary>
        /// User-specific meta data. This can hold anything.
        /// </summary>
        [JsonProperty(PropertyName = "customData")]
        public Dictionary<string, Object> CustomData { get; set; } = new Dictionary<string, Object>();
    }
}
