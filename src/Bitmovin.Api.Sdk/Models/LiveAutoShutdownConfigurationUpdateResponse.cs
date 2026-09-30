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
    /// The auto shutdown configuration that was accepted and applied to the running Live Encoding, together with the instant the encoder armed the shutdown for.  &#x60;streamTimeoutMinutes&#x60; was applied from the moment the encoder accepted the update, not from the start of the encoding, so &#x60;scheduledShutdownAt&#x60; rather than the timeout value is what says when this encoding stops. 
    /// </summary>
    public class LiveAutoShutdownConfigurationUpdateResponse : LiveAutoShutdownConfiguration
    {
        /// <summary>
        /// The instant at which the Live Encoding is currently scheduled to shut down, as reported by the encoder. &#x60;null&#x60; means no shutdown is scheduled.  &#x60;bytesReadTimeoutSeconds&#x60; is not reflected here, as it only arms once the input stops flowing, so the encoding can still shut down earlier than this. 
        /// </summary>
        [JsonProperty(PropertyName = "scheduledShutdownAt")]
        public DateTime? ScheduledShutdownAt { get; internal set; }
    }
}
