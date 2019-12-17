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
    /// AnalyticsResponse
    /// </summary>

    public class AnalyticsResponse
    {
        /// <summary>
        /// Rows
        /// </summary>
        [JsonProperty(PropertyName = "rows")]
        public List<Object> Rows { get; set; } = new List<Object>();
        
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
        
        /// <summary>
        /// ContextDescription
        /// </summary>
        [JsonProperty(PropertyName = "contextDescription")]
        public List<AnalyticsContextDescription> ContextDescription { get; set; } = new List<AnalyticsContextDescription>();
    }

}
