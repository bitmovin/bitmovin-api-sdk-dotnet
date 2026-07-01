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
    /// Output statistics for a live encoding heartbeat.
    /// </summary>
    public class LiveEncodingHeartbeatOutput
    {
        /// <summary>
        /// Manifest statistics for the live encoding output.
        /// </summary>
        [JsonProperty(PropertyName = "manifests")]
        public LiveEncodingHeartbeatManifests Manifests { get; set; }

        /// <summary>
        /// Segment processing statistics for the live encoding output.
        /// </summary>
        [JsonProperty(PropertyName = "segments")]
        public LiveEncodingHeartbeatSegments Segments { get; set; }
    }
}
