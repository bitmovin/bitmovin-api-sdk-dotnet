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
    /// ResetLiveManifestTimeShift
    /// </summary>
    public class ResetLiveManifestTimeShift : BitmovinResponse
    {
        /// <summary>
        /// Determines how many seconds will be left in the manifest after segments are removed. If this is not set, all but one segment will be removed. 
        /// </summary>
        [JsonProperty(PropertyName = "residualPeriodInSeconds")]
        public double? ResidualPeriodInSeconds { get; set; }

        /// <summary>
        /// The ids of the manifests to update. If this property is not set, all manifests tied to the encoding are updated.
        /// </summary>
        [JsonProperty(PropertyName = "manifestIds")]
        public List<string> ManifestIds { get; set; } = new List<string>();

        /// <summary>
        /// If set to true, the Progressive muxing start position will be shifted to the start of the first remaining segment after the removal.  NOTE: This only works for Progressive MP4 muxings.
        /// </summary>
        [JsonProperty(PropertyName = "shiftProgressiveMuxingStartPosition")]
        public bool? ShiftProgressiveMuxingStartPosition { get; set; }
    }
}
