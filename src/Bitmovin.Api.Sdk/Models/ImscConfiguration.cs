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
    /// ImscConfiguration
    /// </summary>
    public class ImscConfiguration : SubtitleConfiguration
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "IMSC";

        /// <summary>
        /// Styling
        /// </summary>
        [JsonProperty(PropertyName = "styling")]
        public ImscStyling Styling { get; set; }
    }
}
