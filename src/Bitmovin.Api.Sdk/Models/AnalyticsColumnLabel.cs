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
    /// AnalyticsColumnLabel
    /// </summary>
    public class AnalyticsColumnLabel
    {
        /// <summary>
        /// Key
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
    }
}
