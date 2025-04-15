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
    /// Rating
    /// </summary>
    public class Rating
    {
        /// <summary>
        /// Region
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// System
        /// </summary>
        [JsonProperty(PropertyName = "system")]
        public string System { get; set; }

        /// <summary>
        /// _Rating
        /// </summary>
        [JsonProperty(PropertyName = "rating")]
        public string _Rating { get; set; }
    }
}
