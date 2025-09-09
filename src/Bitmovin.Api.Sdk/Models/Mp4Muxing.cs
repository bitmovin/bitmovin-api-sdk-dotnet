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
    /// Mp4Muxing
    /// </summary>
    public class Mp4Muxing : Muxing
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "MP4";

        /// <summary>
        /// Name of the output file (either &#x60;filename&#x60; or &#x60;name&#x60; is required, prefer &#x60;filename&#x60;)
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        ///  Duration of fragments in milliseconds. Required for Fragmented MP4 Muxing (for Smooth Streaming or DASH On-Demand). Not setting this will result in unfragmented mp4.
        /// </summary>
        [JsonProperty(PropertyName = "fragmentDuration")]
        public int? FragmentDuration { get; set; }

        /// <summary>
        /// Prevents creation of very short fragments (in seconds). If the last fragment is shorter than minimumFragmentDuration or there is a custom keyframe too close to a fragment boundary, short fragments will be omitted by removing fragment boundaries, resulting in a fragment of a size up to fragmentDuration + minimumFragmentDuration.
        /// </summary>
        [JsonProperty(PropertyName = "minimumFragmentDuration")]
        public double? MinimumFragmentDuration { get; set; }

        /// <summary>
        /// FragmentedMP4MuxingManifestType
        /// </summary>
        [JsonProperty(PropertyName = "fragmentedMP4MuxingManifestType")]
        public FragmentedMp4MuxingManifestType? FragmentedMP4MuxingManifestType { get; set; }

        /// <summary>
        /// Dolby Vision specific configuration
        /// </summary>
        [JsonProperty(PropertyName = "dolbyVisionConfiguration")]
        public DolbyVisionMuxingConfiguration DolbyVisionConfiguration { get; set; }
    }
}
