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
    /// PsnrQualityMetric
    /// </summary>

    public class PsnrQualityMetric
    {
        /// <summary>
        /// TimeSpan
        /// </summary>
        [JsonProperty(PropertyName = "timeSpan")]
        public TimeSpan TimeSpan { get; set; }
        
        /// <summary>
        /// Peak signal-to-noise ratio (required)
        /// </summary>
        [JsonProperty(PropertyName = "psnr")]
        public double? Psnr { get; set; }
    }

}
