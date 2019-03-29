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
    /// AutoRepresentation
    /// </summary>

    public class AutoRepresentation
    {
        /// <summary>
        /// This is the threshold if the settings of the lower or the upper representation (codec configuration) should be used, when representations are added automatically
        /// </summary>
        [JsonProperty(PropertyName = "adoptConfigurationThreshold")]
        public double? AdoptConfigurationThreshold { get; set; }
    }

}
