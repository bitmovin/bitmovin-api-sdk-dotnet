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
    /// CustomAttribute
    /// </summary>
    public class CustomAttribute
    {
        /// <summary>
        /// unique string identifier for the custom attribute (required)
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// value of the custom attribute
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
