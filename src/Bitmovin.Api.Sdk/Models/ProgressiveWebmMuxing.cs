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
    /// ProgressiveWebmMuxing
    /// </summary>
    public class ProgressiveWebmMuxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "PROGRESSIVE_WEBM";

        /// <summary>
        /// Name of the output file
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// ManifestType
        /// </summary>
        [JsonProperty(PropertyName = "manifestType")]
        public ProgressiveWebmMuxingManifestType? ManifestType { get; set; }

        /// <summary>
        /// Determines the length of segments in seconds if manifestType is set to DASH_ON_DEMAND. Defaults to 4 seconds
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public double? SegmentLength { get; set; }
    }
}
