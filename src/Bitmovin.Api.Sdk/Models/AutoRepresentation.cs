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
        /// This is the threshold that determines whether the settings of the lower or the upper template representation (codec configuration) should be used, when representations are added automatically. The value must be between 0 and 1. Values nearer 0 will favour the higher representation, values nearer 1 will favour the lower representation.
        /// </summary>
        [JsonProperty(PropertyName = "adoptConfigurationThreshold")]
        public double? AdoptConfigurationThreshold { get; set; }
    }
}
