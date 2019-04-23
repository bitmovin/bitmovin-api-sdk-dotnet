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
    /// StreamInfos
    /// </summary>

    public class StreamInfos
    {
        /// <summary>
        /// Timestamp of the event formatted in UTC: YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public DateTime? Time { get; set; }
        
        /// <summary>
        /// Details about billable minutes for each resolution category
        /// </summary>
        [JsonProperty(PropertyName = "streamInfos")]
        public List<StreamInfosDetails> _StreamInfos { get; set; }
    }

}
