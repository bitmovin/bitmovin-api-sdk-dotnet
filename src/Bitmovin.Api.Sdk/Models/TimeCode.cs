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
    /// TimeCode
    /// </summary>

    public class TimeCode
    {
        /// <summary>
        /// Specify start timecode for writing.
        /// </summary>
        [JsonProperty(PropertyName = "timeCodeStart")]
        public string TimeCodeStart { get; set; }
    }

}
