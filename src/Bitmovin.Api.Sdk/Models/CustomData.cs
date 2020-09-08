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
    /// CustomData
    /// </summary>
    public class CustomData
    {
        /// <summary>
        /// User-specific meta data. This can hold a custom JSON object.
        /// </summary>
        [JsonProperty(PropertyName = "customData")]
        public Dictionary<string, Object> _CustomData { get; set; } = new Dictionary<string, Object>();

        /// <summary>
        /// Creation timestamp, returned as UTC expressed in ISO 8601 format: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }
    }
}
