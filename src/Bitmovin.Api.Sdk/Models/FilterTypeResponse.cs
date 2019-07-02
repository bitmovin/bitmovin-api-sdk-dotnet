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
    /// FilterTypeResponse
    /// </summary>

    public class FilterTypeResponse
    {
        /// <summary>
        /// The type of the filter
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FilterType? Type { get; set; }
    }

}
