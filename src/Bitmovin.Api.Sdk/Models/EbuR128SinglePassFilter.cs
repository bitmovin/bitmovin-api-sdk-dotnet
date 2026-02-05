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
    /// EbuR128SinglePassFilter
    /// </summary>
    public class EbuR128SinglePassFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "EBU_R128_SINGLE_PASS";
#pragma warning restore CS0414

        /// <summary>
        /// Set the targeted integrated loudness value. Range is from &#39;-70.0&#39; to &#39;-5.0&#39;. Default value is &#39;-24.0&#39;. Value is measured in LUFS (Loudness Units, referenced to Full Scale)
        /// </summary>
        [JsonProperty(PropertyName = "integratedLoudness")]
        public double? IntegratedLoudness { get; set; }

        /// <summary>
        /// Set the targeted loudness range target. Range is from &#39;1.0&#39; to &#39;20.0&#39;. Default value is &#39;7.0&#39;. Loudness range measures the variation of loudness on a macroscopic time-scale in units of LU (Loudness Units). For programmes shorter than 1 minute, the use of the measure Loudness Range is not recommended due to too few data points (Loudness Range is based on the Short-term-Loudness values (3-seconds-window)).
        /// </summary>
        [JsonProperty(PropertyName = "loudnessRange")]
        public double? LoudnessRange { get; set; }

        /// <summary>
        /// Set maximum true peak. Range is from &#39;-9.0&#39; to &#39;0.0&#39;. Default value is &#39;-2.0&#39;. Values are measured in dBTP (db True Peak)
        /// </summary>
        [JsonProperty(PropertyName = "maximumTruePeakLevel")]
        public double? MaximumTruePeakLevel { get; set; }
    }
}
