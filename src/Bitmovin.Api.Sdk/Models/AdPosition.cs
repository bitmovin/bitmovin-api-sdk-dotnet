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
    /// AdPosition
    /// </summary>
    public class AdPosition
    {
        /// <summary>
        /// Position
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public double? Position { get; set; }
    }
}
