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
    /// Statistics
    /// </summary>

    public class Statistics
    {
        /// <summary>
        /// Bytes encoded total.
        /// </summary>
        [JsonProperty(PropertyName = "bytesEncodedTotal")]
        public long? BytesEncodedTotal { get; set; }
        
        /// <summary>
        /// Time in seconds encoded for all contained daily statistics.
        /// </summary>
        [JsonProperty(PropertyName = "timeEncodedTotal")]
        public long? TimeEncodedTotal { get; set; }
    }

}
