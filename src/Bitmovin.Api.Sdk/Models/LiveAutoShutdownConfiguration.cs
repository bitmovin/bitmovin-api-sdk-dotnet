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
    /// LiveAutoShutdownConfiguration
    /// </summary>
    public class LiveAutoShutdownConfiguration
    {
        /// <summary>
        /// Automatically shutdown the live stream if there is no input anymore for a predefined number of seconds.
        /// </summary>
        [JsonProperty(PropertyName = "bytesReadTimeoutSeconds")]
        public long? BytesReadTimeoutSeconds { get; set; }

        /// <summary>
        /// Automatically shutdown the live stream after a predefined runtime in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "streamTimeoutMinutes")]
        public long? StreamTimeoutMinutes { get; set; }

        /// <summary>
        /// Automatically shutdown the live stream if input is never connected for a predefined number of minutes.
        /// </summary>
        [JsonProperty(PropertyName = "waitingForFirstConnectTimeoutMinutes")]
        public long? WaitingForFirstConnectTimeoutMinutes { get; set; }
    }
}
