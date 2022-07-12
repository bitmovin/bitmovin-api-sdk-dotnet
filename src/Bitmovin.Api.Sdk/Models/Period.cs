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
    /// Period
    /// </summary>
    public class Period : BitmovinResponse
    {
        /// <summary>
        /// Starting time in seconds
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public double? Start { get; set; }

        /// <summary>
        /// Duration in seconds.&lt;br/&gt;Please note that the duration of a Period is usually determined by the media contained therein.&lt;br/&gt;Setting the &#x60;duration&#x60; property to a specific value will override this default behaviour.&lt;br/&gt;Warning: Use at your own risk!
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public double? Duration { get; set; }
    }
}
