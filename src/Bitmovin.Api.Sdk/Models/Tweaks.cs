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
    /// Tweaks
    /// </summary>
    public class Tweaks
    {
        /// <summary>
        /// Defines special audio video sync handling
        /// </summary>
        [JsonProperty(PropertyName = "audioVideoSyncMode")]
        public AudioVideoSyncMode? AudioVideoSyncMode { get; set; }
    }
}
