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
    /// AnalyticsLicenseCustomDataFieldLabels
    /// </summary>
    public class AnalyticsLicenseCustomDataFieldLabels
    {
        /// <summary>
        /// Custom Data 1
        /// </summary>
        [JsonProperty(PropertyName = "customData1")]
        public string CustomData1 { get; set; }

        /// <summary>
        /// Custom Data 2
        /// </summary>
        [JsonProperty(PropertyName = "customData2")]
        public string CustomData2 { get; set; }

        /// <summary>
        /// Custom Data 3
        /// </summary>
        [JsonProperty(PropertyName = "customData3")]
        public string CustomData3 { get; set; }

        /// <summary>
        /// Custom Data 4
        /// </summary>
        [JsonProperty(PropertyName = "customData4")]
        public string CustomData4 { get; set; }

        /// <summary>
        /// Custom Data 5
        /// </summary>
        [JsonProperty(PropertyName = "customData5")]
        public string CustomData5 { get; set; }
    }
}
