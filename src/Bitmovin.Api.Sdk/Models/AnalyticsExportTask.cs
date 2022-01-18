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
    /// AnalyticsExportTask
    /// </summary>
    public class AnalyticsExportTask : BitmovinResponse
    {
        /// <summary>
        /// Start of timeframe which is exported in UTC format (required)
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// End of timeframe which is exported in UTC format (required)
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Name of the export task (required)
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Export task description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// License key (required)
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }

        /// <summary>
        /// Output
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public AnalyticsExportTaskOutputTarget Output { get; set; }

        /// <summary>
        /// Progress of the export task
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public int? Progress { get; internal set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public AnalyticsExportStatus? Status { get; internal set; }

        /// <summary>
        /// UTC timestamp when the export task started
        /// </summary>
        [JsonProperty(PropertyName = "startedAt")]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// UTC timestamp when the export task finished
        /// </summary>
        [JsonProperty(PropertyName = "finishedAt")]
        public DateTime? FinishedAt { get; internal set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public AnalyticsExportType? Type { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public List<string> Columns { get; set; } = new List<string>();

        /// <summary>
        /// File format of export file
        /// </summary>
        [JsonProperty(PropertyName = "fileFormat")]
        public AnalyticsExportFileFormat? FileFormat { get; set; }
    }
}
