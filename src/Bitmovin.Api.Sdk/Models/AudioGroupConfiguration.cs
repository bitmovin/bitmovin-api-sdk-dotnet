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
    /// AudioGroupConfiguration
    /// </summary>
    public class AudioGroupConfiguration
    {
        /// <summary>
        /// Dropping mode (required)
        /// </summary>
        [JsonProperty(PropertyName = "droppingMode")]
        public VariantStreamDroppingMode? DroppingMode { get; set; }

        /// <summary>
        /// Audio groups (required)
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public List<AudioGroup> Groups { get; set; } = new List<AudioGroup>();
    }
}
