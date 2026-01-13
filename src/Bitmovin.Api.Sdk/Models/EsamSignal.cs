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
    /// ESAM signal following the SCTE-250 standard
    /// </summary>
    public class EsamSignal
    {
        /// <summary>
        /// The offset from the matched signal in ISO 8601 duration format, accurate to milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public string Offset { get; set; }

        /// <summary>
        /// Base64-encoded SCTE-35 binary data to be inserted into the stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "binary")]
        public string Binary { get; set; }

        /// <summary>
        /// Interval in ISO 8601 duration format for which the signal should be repeated.  A signal may be specified as repeating when the interval and end attributes are present.  In this case, the signal is executed at the time specified by offset and again at the time  specified by adding interval to offset. This should be continued until reaching the duration  of offset + end. 
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public string Interval { get; set; }

        /// <summary>
        /// End duration in ISO 8601 duration format when a repeated signal should stop being repeated
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public string End { get; set; }
    }
}
