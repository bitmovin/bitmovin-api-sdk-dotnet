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
    /// PccHdrDevice
    /// </summary>
    public class PccHdrDevice
    {
        /// <summary>
        /// Opaque stable pool key for row identity. Do not display it as a device name. (required)
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Qualifier
        /// </summary>
        [JsonProperty(PropertyName = "qualifier")]
        public string Qualifier { get; set; }

        /// <summary>
        /// All selected HDR playback passes for this device pool. (required)
        /// </summary>
        [JsonProperty(PropertyName = "passes")]
        public decimal? Passes { get; set; }

        /// <summary>
        /// Service-resolved verdict: negative findings outrank positive results. Null when no pass carries an HDR reading. (required)
        /// </summary>
        [JsonProperty(PropertyName = "verdict")]
        public PccDeviceHdrVerdict Verdict { get; set; }

        /// <summary>
        /// Outcomes
        /// </summary>
        [JsonProperty(PropertyName = "outcomes")]
        public List<PccHdrOutcomeCount> Outcomes { get; set; } = new List<PccHdrOutcomeCount>();
    }
}
