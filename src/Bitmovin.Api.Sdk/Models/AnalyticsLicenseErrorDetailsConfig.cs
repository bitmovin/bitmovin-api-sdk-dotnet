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
    /// AnalyticsLicenseErrorDetailsConfig
    /// </summary>
    public class AnalyticsLicenseErrorDetailsConfig
    {
        /// <summary>
        /// Are error details enabled on the license
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; internal set; }

        /// <summary>
        /// Is network explorer feature enabled for the license
        /// </summary>
        [JsonProperty(PropertyName = "networkExplorerEnabled")]
        public bool? NetworkExplorerEnabled { get; internal set; }
    }
}
