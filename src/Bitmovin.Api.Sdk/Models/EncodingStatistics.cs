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
    /// EncodingStatistics
    /// </summary>

    public class EncodingStatistics
    {
        /// <summary>
        /// Date, format. yyyy-MM-dd (required)
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }
        
        /// <summary>
        /// Bytes encoded for this encoding. (required)
        /// </summary>
        [JsonProperty(PropertyName = "bytesEncoded")]
        public long? BytesEncoded { get; set; }
        
        /// <summary>
        /// Time in seconds encoded for this encoding. (required)
        /// </summary>
        [JsonProperty(PropertyName = "timeEncoded")]
        public long? TimeEncoded { get; set; }
    }

}
