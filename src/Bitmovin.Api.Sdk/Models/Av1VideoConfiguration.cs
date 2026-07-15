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
    /// Av1VideoConfiguration
    /// </summary>
    public class Av1VideoConfiguration : VideoConfiguration
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "AV1";
#pragma warning restore CS0414

        /// <summary>
        /// Use a set of well defined configurations preset to support certain use cases. Can be overwritten with more specific values.
        /// </summary>
        [JsonProperty(PropertyName = "presetConfiguration")]
        public Av1PresetConfiguration? PresetConfiguration { get; set; }

        /// <summary>
        /// Enable/disable automatic calculation of level, maxBitrate, and bufsize based on the least level that satisfies maximum property values for picture resolution, frame rate, and bit rate. In the case the target level is set explicitly, the maximum bitrate and buffer size are calculated based on the defined level. Explicitly setting maxBitrate, or bufsize properties will disable the automatic calculation.
        /// </summary>
        [JsonProperty(PropertyName = "autoLevelSetup")]
        public AutoLevelSetup? AutoLevelSetup { get; set; }

        /// <summary>
        /// Set the mastering display color volume metadata. The chromaticity coordinates for the green (G), blue (B), red (R) primaries and the white point (WP) are given in increments of 0.00002 (i.e. multiply the actual value by 50000), and the luminance values (L) are given in increments of 0.0001 cd/m² (i.e. multiply the actual value by 10000). For example &#x60;G(13250,34500)B(7500,3000)R(34000,16000)WP(15635,16450)L(10000000,1)&#x60; describes a P3D65 1000-nits monitor, where G(x&#x3D;0.265, y&#x3D;0.690), B(x&#x3D;0.150, y&#x3D;0.060), R(x&#x3D;0.680, y&#x3D;0.320), WP(x&#x3D;0.3127, y&#x3D;0.3290), L(max&#x3D;1000, min&#x3D;0.0001). Part of HDR-10 metadata.
        /// </summary>
        [JsonProperty(PropertyName = "masterDisplay")]
        public string MasterDisplay { get; set; }

        /// <summary>
        /// Set the max content light level (MaxCLL). Use together with maxPictureAverageLightLevel (which will be 0 if not set). Part of HDR-10 metadata.
        /// </summary>
        [JsonProperty(PropertyName = "maxContentLightLevel")]
        public int? MaxContentLightLevel { get; set; }

        /// <summary>
        /// Set the maximum picture average light level (MaxFALL). Use together with maxContentLightLevel (which will be 0 if not set). Part of HDR-10 metadata.
        /// </summary>
        [JsonProperty(PropertyName = "maxPictureAverageLightLevel")]
        public int? MaxPictureAverageLightLevel { get; set; }
    }
}
