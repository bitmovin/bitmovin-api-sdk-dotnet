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
    /// PccHdrSummary
    /// </summary>
    public class PccHdrSummary
    {
        /// <summary>
        /// Outcomes
        /// </summary>
        [JsonProperty(PropertyName = "outcomes")]
        public List<PccHdrOutcomeCount> Outcomes { get; set; } = new List<PccHdrOutcomeCount>();

        /// <summary>
        /// Selected device pools with at least one HDR playback pass. (required)
        /// </summary>
        [JsonProperty(PropertyName = "byDevice")]
        public List<PccHdrDevice> ByDevice { get; set; } = new List<PccHdrDevice>();

        /// <summary>
        /// Shares
        /// </summary>
        [JsonProperty(PropertyName = "shares")]
        public List<PccHdrShare> Shares { get; set; } = new List<PccHdrShare>();

        /// <summary>
        /// HDR passes in the report. The picture question does not arise on a cell that failed. (required)
        /// </summary>
        [JsonProperty(PropertyName = "passes")]
        public decimal? Passes { get; set; }

        /// <summary>
        /// Passes carrying no reading at all, so a missing measurement never reads as a level of confidence. (required)
        /// </summary>
        [JsonProperty(PropertyName = "unreported")]
        public decimal? Unreported { get; set; }

        /// <summary>
        /// Passes where some instrument answered — frames read, or the device&#39;s own word. The &#x60;evidence&#x60; and &#x60;claim&#x60; shares above, added together. (required)
        /// </summary>
        [JsonProperty(PropertyName = "established")]
        public decimal? Established { get; set; }

        /// <summary>
        /// Findings
        /// </summary>
        [JsonProperty(PropertyName = "findings")]
        public List<PccHdrFinding> Findings { get; set; } = new List<PccHdrFinding>();
    }
}
