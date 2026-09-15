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
    /// PccCoverage
    /// </summary>
    public class PccCoverage
    {
        /// <summary>
        /// Distinct pools in the held measurement before any view exclusions. (required)
        /// </summary>
        [JsonProperty(PropertyName = "devicesBeforeView")]
        public int? DevicesBeforeView { get; set; }

        /// <summary>
        /// Pools omitted by the device filter after prerelease exclusions. Each omitted pool is counted once, in prerelease, device-filter, then reported-only order. (required)
        /// </summary>
        [JsonProperty(PropertyName = "devicesExcludedByDeviceFilter")]
        public int? DevicesExcludedByDeviceFilter { get; set; }

        /// <summary>
        /// Pools omitted by reportedOnly because no selected cell answers about the device, after prerelease and device-filter exclusions. (required)
        /// </summary>
        [JsonProperty(PropertyName = "devicesExcludedAsUnreported")]
        public int? DevicesExcludedAsUnreported { get; set; }

        /// <summary>
        /// Distinct pools omitted because all recorded browser evidence is pre-release. Zero when includePrerelease is true. Unknown browser identities do not cause prerelease exclusion. Row coverage and summaries describe the retained pools. (required)
        /// </summary>
        [JsonProperty(PropertyName = "devicesExcludedAsPrerelease")]
        public int? DevicesExcludedAsPrerelease { get; set; }

        /// <summary>
        /// Devices
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public decimal? Devices { get; set; }

        /// <summary>
        /// Pools with no included sessions. Present in the report as unmeasured, including when the start date excluded all evidence. (required)
        /// </summary>
        [JsonProperty(PropertyName = "devicesWithNoSession")]
        public decimal? DevicesWithNoSession { get; set; }

        /// <summary>
        /// Pools every one of whose sessions came from one physical machine — a claim about that machine, not the model. (required)
        /// </summary>
        [JsonProperty(PropertyName = "devicesOnOneUnit")]
        public decimal? DevicesOnOneUnit { get; set; }

        /// <summary>
        /// Pools no naming rule recognised, published under the stated placeholder. Counted here so a reader can tell how much of the fleet this report cannot name rather than discovering it row by row. (required)
        /// </summary>
        [JsonProperty(PropertyName = "devicesUnderPlaceholderName")]
        public decimal? DevicesUnderPlaceholderName { get; set; }

        /// <summary>
        /// Cells whose verdict rests on a single session. (required)
        /// </summary>
        [JsonProperty(PropertyName = "cellsOnOneSession")]
        public decimal? CellsOnOneSession { get; set; }

        /// <summary>
        /// Jobs the fleet could not attribute to any pool, so no row of this report accounts for them. (required)
        /// </summary>
        [JsonProperty(PropertyName = "unattributableJobs")]
        public decimal? UnattributableJobs { get; set; }

        /// <summary>
        /// Jobs that had not finished when this was assembled. Their pools carry nothing measured. (required)
        /// </summary>
        [JsonProperty(PropertyName = "unsettledJobs")]
        public decimal? UnsettledJobs { get; set; }

        /// <summary>
        /// Pools with sessions excluded by the start date or session limit, including those with no included evidence. (required)
        /// </summary>
        [JsonProperty(PropertyName = "devicesOnRecentEvidence")]
        public decimal? DevicesOnRecentEvidence { get; set; }
    }
}
