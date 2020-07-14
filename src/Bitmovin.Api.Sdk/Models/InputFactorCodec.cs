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
    /// InputFactorCodec
    /// </summary>
    public class InputFactorCodec
    {
        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Factor
        /// </summary>
        [JsonProperty(PropertyName = "factor")]
        public decimal? Factor { get; set; }
    }
}
