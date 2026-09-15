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
    /// PccDeviceHdrVerdict
    /// </summary>
    public class PccDeviceHdrVerdict
    {
        /// <summary>
        /// Mark
        /// </summary>
        [JsonProperty(PropertyName = "mark")]
        public string Mark { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Confidence
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public PccHdrConfidence? Confidence { get; set; }

        /// <summary>
        /// Actionable
        /// </summary>
        [JsonProperty(PropertyName = "actionable")]
        public bool? Actionable { get; set; }

        /// <summary>
        /// HDR passes supporting this verdict, not all passes for the device. (required)
        /// </summary>
        [JsonProperty(PropertyName = "passes")]
        public decimal? Passes { get; set; }
    }
}
