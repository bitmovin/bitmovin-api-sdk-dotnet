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
    /// PccReportView
    /// </summary>
    public class PccReportView
    {
        /// <summary>
        /// Effective trimmed lowercase substring matched against the published device name and qualifier. Empty means all devices. (required)
        /// </summary>
        [JsonProperty(PropertyName = "device")]
        public string Device { get; set; }

        /// <summary>
        /// Effective trimmed lowercase substring matched against codec identifiers. Empty means all codecs. (required)
        /// </summary>
        [JsonProperty(PropertyName = "codec")]
        public string Codec { get; set; }

        /// <summary>
        /// Whether only HDR columns are selected. (required)
        /// </summary>
        [JsonProperty(PropertyName = "hdrOnly")]
        public bool? HdrOnly { get; set; }

        /// <summary>
        /// Whether pools need at least one selected cell answering about the device. (required)
        /// </summary>
        [JsonProperty(PropertyName = "reportedOnly")]
        public bool? ReportedOnly { get; set; }

        /// <summary>
        /// Whether pools with only prerelease browser evidence are included. (required)
        /// </summary>
        [JsonProperty(PropertyName = "includePrerelease")]
        public bool? IncludePrerelease { get; set; }
    }
}
