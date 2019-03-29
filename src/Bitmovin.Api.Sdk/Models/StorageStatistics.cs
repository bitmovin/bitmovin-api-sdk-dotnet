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
    /// StorageStatistics
    /// </summary>

    public class StorageStatistics
    {
        /// <summary>
        /// BytesStored
        /// </summary>
        [JsonProperty(PropertyName = "bytesStored")]
        public long? BytesStored { get; set; }
        
        /// <summary>
        /// BytesTransferred
        /// </summary>
        [JsonProperty(PropertyName = "bytesTransferred")]
        public long? BytesTransferred { get; set; }
        
        /// <summary>
        /// Storage
        /// </summary>
        [JsonProperty(PropertyName = "storage")]
        public string Storage { get; set; }
    }

}
