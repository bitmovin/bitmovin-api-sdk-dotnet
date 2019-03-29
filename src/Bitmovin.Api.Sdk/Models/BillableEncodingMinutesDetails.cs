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
    /// BillableEncodingMinutesDetails
    /// </summary>

    public class BillableEncodingMinutesDetails
    {
        /// <summary>
        /// Only set if resolution information is not present.
        /// </summary>
        [JsonProperty(PropertyName = "UNKNOWN")]
        public long? UNKNOWN { get; set; }
        
        /// <summary>
        /// Billable minutes for audio. Available if stream is an audio stream.
        /// </summary>
        [JsonProperty(PropertyName = "AUDIO")]
        public long? AUDIO { get; set; }
        
        /// <summary>
        /// Billable minutes for SD resolutions.
        /// </summary>
        [JsonProperty(PropertyName = "SD")]
        public long? SD { get; set; }
        
        /// <summary>
        /// Billable minutes for HD resolutions.
        /// </summary>
        [JsonProperty(PropertyName = "HD")]
        public long? HD { get; set; }
        
        /// <summary>
        /// Billable minutes for UHD resolutions.
        /// </summary>
        [JsonProperty(PropertyName = "UHD")]
        public long? UHD { get; set; }
    }

}
