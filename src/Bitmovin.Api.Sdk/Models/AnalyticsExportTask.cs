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
        /// Start of timeframe which is exported in UTC format
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }
        
        /// <summary>
        /// End of timeframe which is exported in UTC format
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }
        
        /// <summary>
        /// Name of the export task
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Export task description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <summary>
        /// License key
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }
        
        /// <summary>
        /// Output
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public AnalyticsExportTaskOutputTarget Output { get; set; }
    }

}
