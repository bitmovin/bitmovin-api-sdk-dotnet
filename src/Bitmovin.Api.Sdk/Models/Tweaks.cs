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
        /// Different modes for syncing the start and end of audio input streams with the video inputs. This feature does not work with Dolby Digital (Plus) or Dolby Atmos.
        /// </summary>
        [JsonProperty(PropertyName = "audioVideoSyncMode")]
        public AudioVideoSyncMode? AudioVideoSyncMode { get; set; }
    }
}
