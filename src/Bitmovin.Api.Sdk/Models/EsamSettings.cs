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
    /// EsamSettings
    /// </summary>
    public class EsamSettings
    {
        /// <summary>
        /// The URL of the Placement Opportunity Information System (POIS) signal processing endpoint. The encoder transmits SignalProcessingEvents to this endpoint whenever SCTE-35 messages are detected. 
        /// </summary>
        [JsonProperty(PropertyName = "poisEndpoint")]
        public string PoisEndpoint { get; set; }

        /// <summary>
        /// A unique identifier representing the &#x60;Acquisition Point Identity&#x60; defined in the ESAM specification. 
        /// </summary>
        [JsonProperty(PropertyName = "acquisitionPointIdentity")]
        public string AcquisitionPointIdentity { get; set; }

        /// <summary>
        /// Specifies the &#x60;Zone Identity&#x60; defined in the ESAM specification. 
        /// </summary>
        [JsonProperty(PropertyName = "zoneIdentity")]
        public string ZoneIdentity { get; set; }

        /// <summary>
        /// Defines an offset (in milliseconds) to be applied to the stream event timestamp. This offset adjusts the &#x60;StreamTime&#x60; values (such as PTS) associated with ad opportunities or content insertions. It is used to fine-tune timing for embedded SCTE-104/35 messages to ensure precise frame alignment in the transport stream. 
        /// </summary>
        [JsonProperty(PropertyName = "adAvailOffset")]
        public int? AdAvailOffset { get; set; }

        /// <summary>
        /// If authentication is required to access the POIS endpoint, credentials must be provided. 
        /// </summary>
        [JsonProperty(PropertyName = "poisEndpointCredentials")]
        public PoisEndpointCredentials PoisEndpointCredentials { get; set; }
    }
}
