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
    /// StreamPerTitleSettings
    /// </summary>

    public class StreamPerTitleSettings
    {
        /// <summary>
        /// Settings for PER_TITLE_TEMPLATE_FIXED_RESOLUTION_AND_BITRATE mode
        /// </summary>
        [JsonProperty(PropertyName = "fixedResolutionAndBitrateSettings")]
        public StreamPerTitleFixedResolutionAndBitrateSettings FixedResolutionAndBitrateSettings { get; set; }
    }

}
