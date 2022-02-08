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
    /// Av1PerTitleConfiguration
    /// </summary>
    public class Av1PerTitleConfiguration : PerTitleConfiguration
    {
        /// <summary>
        /// Desired target quality of the highest representation expressed as CRF value
        /// </summary>
        [JsonProperty(PropertyName = "targetQualityCrf")]
        public double? TargetQualityCrf { get; set; }
    }
}
