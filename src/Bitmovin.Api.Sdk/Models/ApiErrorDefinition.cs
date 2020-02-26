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
    /// ApiErrorDefinition
    /// </summary>
    public class ApiErrorDefinition
    {
        /// <summary>
        /// The error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public long? Code { get; set; }

        /// <summary>
        /// The error category.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// The returned error description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
