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
    /// AnalyticsExportTaskOutputTarget
    /// </summary>

    public class AnalyticsExportTaskOutputTarget
    {
        /// <summary>
        /// Path where the export should be saved
        /// </summary>
        [JsonProperty(PropertyName = "outputPath")]
        public string OutputPath { get; set; }
        
        /// <summary>
        /// Id of the output that should be used
        /// </summary>
        [JsonProperty(PropertyName = "outputId")]
        public string OutputId { get; set; }
    }

}
