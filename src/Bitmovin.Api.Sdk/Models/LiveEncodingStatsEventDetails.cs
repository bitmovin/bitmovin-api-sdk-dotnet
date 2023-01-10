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
    /// LiveEncodingStatsEventDetails
    /// </summary>
    public class LiveEncodingStatsEventDetails
    {
        /// <summary>
        /// EventType
        /// </summary>
        [JsonProperty(PropertyName = "eventType")]
        public LiveEncodingEventName? EventType { get; set; }
    }
}
