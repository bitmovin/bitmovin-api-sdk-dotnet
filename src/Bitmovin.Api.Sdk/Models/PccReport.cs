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
    /// PccReport
    /// </summary>
    public class PccReport
    {
        /// <summary>
        /// Identifies this report. A new generation produces a new one. (required)
        /// </summary>
        [JsonProperty(PropertyName = "reportId")]
        public string ReportId { get; set; }

        /// <summary>
        /// When the generation that produced this report finished. (required)
        /// </summary>
        [JsonProperty(PropertyName = "generatedAt")]
        public string GeneratedAt { get; set; }

        /// <summary>
        /// The selected report. By default, pools whose recorded browsers are all pre-release are excluded; includePrerelease retains them. Unknown browser identities do not cause prerelease exclusion. Null where a report is held that this service cannot read, which a generation replaces. (required)
        /// </summary>
        [JsonProperty(PropertyName = "report")]
        public PccCompatibilityMatrix Report { get; set; }
    }
}
