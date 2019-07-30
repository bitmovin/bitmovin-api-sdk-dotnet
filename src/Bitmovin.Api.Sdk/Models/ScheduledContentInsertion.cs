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
    /// ScheduledContentInsertion
    /// </summary>

    public class ScheduledContentInsertion : BitmovinResource
    {
        /// <summary>
        /// Id of the insertable content to play instead of the live stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "contentId")]
        public string ContentId { get; set; }
        
        /// <summary>
        /// Time to to play the content in UTC: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "runAt")]
        public DateTime? RunAt { get; set; }
        
        /// <summary>
        /// Duration for how long to play the content. Cut off if shorter, loop if longer than actual duration.
        /// </summary>
        [JsonProperty(PropertyName = "durationInSeconds")]
        public double? DurationInSeconds { get; set; }
        
        /// <summary>
        /// Status of the scheduled content insertion.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ScheduledContentInsertionStatus? Status { get; internal set; }
    }

}
