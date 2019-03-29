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
    /// OverallStatistics
    /// </summary>

    public class OverallStatistics
    {
        /// <summary>
        /// BytesStoredTotal
        /// </summary>
        [JsonProperty(PropertyName = "bytesStoredTotal")]
        public long? BytesStoredTotal { get; set; }
        
        /// <summary>
        /// BytesTransferredTotal
        /// </summary>
        [JsonProperty(PropertyName = "bytesTransferredTotal")]
        public long? BytesTransferredTotal { get; set; }
        
        /// <summary>
        /// Storages
        /// </summary>
        [JsonProperty(PropertyName = "storages")]
        public List<StorageStatistics> Storages { get; set; }
    }

}
