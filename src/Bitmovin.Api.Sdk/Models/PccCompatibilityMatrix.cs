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
    /// PccCompatibilityMatrix
    /// </summary>
    public class PccCompatibilityMatrix
    {
        /// <summary>
        /// The effective selection already applied to this matrix, its summary and coverage. (required)
        /// </summary>
        [JsonProperty(PropertyName = "view")]
        public PccReportView View { get; set; }

        /// <summary>
        /// When this report was assembled from what had been measured by then. (required)
        /// </summary>
        [JsonProperty(PropertyName = "assembledAt")]
        public string AssembledAt { get; set; }

        /// <summary>
        /// Every Bitmovin Player version that measured any device here. More than one means the measurement spanned a player release, and support is a property of the player and the device together. (required)
        /// </summary>
        [JsonProperty(PropertyName = "playerVersions")]
        public List<string> PlayerVersions { get; set; } = new List<string>();

        /// <summary>
        /// UUIDs of matching runs whose job metadata was read, including runs with no included session evidence. Never run names. Quote one to Bitmovin support while the fleet still holds it. The count says nothing about coverage. (required)
        /// </summary>
        [JsonProperty(PropertyName = "runIds")]
        public List<string> RunIds { get; set; } = new List<string>();

        /// <summary>
        /// Inclusive run creation instant in UTC used by this generation, or null for no cutoff. Legacy dates mean midnight UTC. Changing the held cutoff does not alter this report. (required)
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Maximum sessions read per pool by this generation. Null for reports produced before a limit was recorded. (required)
        /// </summary>
        [JsonProperty(PropertyName = "sessionLimit")]
        public int? SessionLimit { get; set; }

        /// <summary>
        /// Coverage
        /// </summary>
        [JsonProperty(PropertyName = "coverage")]
        public PccCoverage Coverage { get; set; }

        /// <summary>
        /// Every verdict mark and its wording, so the grid reads without this service&#39;s source. (required)
        /// </summary>
        [JsonProperty(PropertyName = "legend")]
        public List<PccVerdictLegendEntry> Legend { get; set; } = new List<PccVerdictLegendEntry>();

        /// <summary>
        /// The same for the marks an HDR result wears. (required)
        /// </summary>
        [JsonProperty(PropertyName = "hdrLegend")]
        public List<PccHdrLegendEntry> HdrLegend { get; set; } = new List<PccHdrLegendEntry>();

        /// <summary>
        /// Combinations
        /// </summary>
        [JsonProperty(PropertyName = "combinations")]
        public List<PccCombination> Combinations { get; set; } = new List<PccCombination>();

        /// <summary>
        /// Devices
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public List<PccDevice> Devices { get; set; } = new List<PccDevice>();

        /// <summary>
        /// Summary
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public PccSummary Summary { get; set; }
    }
}
