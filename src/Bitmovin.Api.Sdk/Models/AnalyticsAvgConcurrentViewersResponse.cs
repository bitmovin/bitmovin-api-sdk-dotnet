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
    /// AnalyticsAvgConcurrentViewersResponse
    /// </summary>
    public class AnalyticsAvgConcurrentViewersResponse
    {
        /// <summary>
        /// Rows
        /// </summary>
        [JsonProperty(PropertyName = "rows")]
        public List<double?> Rows { get; set; } = new List<double?>();

        /// <summary>
        /// Number of rows returned
        /// </summary>
        [JsonProperty(PropertyName = "rowCount")]
        public long? RowCount { get; set; }

        /// <summary>
        /// ColumnLabels
        /// </summary>
        [JsonProperty(PropertyName = "columnLabels")]
        public List<AnalyticsColumnLabel> ColumnLabels { get; set; } = new List<AnalyticsColumnLabel>();
    }
}
