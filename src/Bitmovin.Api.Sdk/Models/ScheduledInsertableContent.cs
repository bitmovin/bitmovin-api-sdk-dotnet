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
    /// ScheduledInsertableContent
    /// </summary>
    public class ScheduledInsertableContent : BitmovinResource
    {
        /// <summary>
        /// Id of the insertable content to play instead of the live stream
        /// </summary>
        [JsonProperty(PropertyName = "contentId")]
        public string ContentId { get; set; }

        /// <summary>
        /// Time to play the content in UTC: YYYY-MM-DDThh:mm:ssZ, if this property is not set the content will be played as soon as possible.
        /// </summary>
        [JsonProperty(PropertyName = "runAt")]
        public DateTime? RunAt { get; set; }

        /// <summary>
        /// Duration for how long to play the content. Cut off if shorter, loop if longer than actual duration. This property is required if the insertable content is an image.
        /// </summary>
        [JsonProperty(PropertyName = "durationInSeconds")]
        public double? DurationInSeconds { get; set; }

        /// <summary>
        /// Status of the scheduled insertable content.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ScheduledInsertableContentStatus? Status { get; internal set; }
    }
}
