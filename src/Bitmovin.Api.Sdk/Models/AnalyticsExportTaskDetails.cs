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
    /// AnalyticsExportTaskDetails
    /// </summary>

    public class AnalyticsExportTaskDetails : AnalyticsExportTask
    {
        /// <summary>
        /// Progress of the export task
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public int? Progress { get; set; }
        
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public AnalyticsExportStatus Status { get; set; }
        
        /// <summary>
        /// UTC timestamp when the export task started
        /// </summary>
        [JsonProperty(PropertyName = "startedAt")]
        public string StartedAt { get; set; }
        
        /// <summary>
        /// UTC timestamp when the export task finished
        /// </summary>
        [JsonProperty(PropertyName = "finishedAt")]
        public string FinishedAt { get; set; }
    }

}
