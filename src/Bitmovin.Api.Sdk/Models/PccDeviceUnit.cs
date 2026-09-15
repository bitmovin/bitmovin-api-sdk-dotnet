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
    /// PccDeviceUnit
    /// </summary>
    public class PccDeviceUnit
    {
        /// <summary>
        /// The fleet&#39;s identifier for one physical machine, so two rows of the same pool can be told apart. (required)
        /// </summary>
        [JsonProperty(PropertyName = "unitId")]
        public string UnitId { get; set; }

        /// <summary>
        /// SessionIds
        /// </summary>
        [JsonProperty(PropertyName = "sessionIds")]
        public List<string> SessionIds { get; set; } = new List<string>();

        /// <summary>
        /// BrowserVersion
        /// </summary>
        [JsonProperty(PropertyName = "browserVersion")]
        public string BrowserVersion { get; set; }

        /// <summary>
        /// OsVersion
        /// </summary>
        [JsonProperty(PropertyName = "osVersion")]
        public string OsVersion { get; set; }

        /// <summary>
        /// Attribute tags such as &#x60;webos:firmwareVersion:33.23.05&#x60;, which is where a television&#39;s firmware lives.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public List<string> Tags { get; set; } = new List<string>();
    }
}
