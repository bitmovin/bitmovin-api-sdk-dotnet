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
    /// PrewarmedEncoderPoolSchedule
    /// </summary>
    public class PrewarmedEncoderPoolSchedule : BitmovinResponse
    {
        /// <summary>
        /// The action to be triggered by the schedule (start or stop) (required)
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public PrewarmedEncoderPoolAction? Action { get; set; }

        /// <summary>
        /// An instant in the future when the specified action should be triggered. Given as UTC expressed in ISO 8601 format (\&quot;YYYY-MM-DDThh:mm:ssZ\&quot;). Seconds will be ignored. (required)
        /// </summary>
        [JsonProperty(PropertyName = "triggerDate")]
        public DateTime? TriggerDate { get; set; }
    }
}
