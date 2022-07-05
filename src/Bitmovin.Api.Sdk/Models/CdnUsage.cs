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
    /// CdnUsage
    /// </summary>
    public class CdnUsage
    {
        /// <summary>
        /// UTC timestamp which marks the beginning of the time period for which the usage statistics are retrieved.
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public DateTime? From { get; internal set; }

        /// <summary>
        /// UTC timestamp which marks the end of the time period for which the usage statistics are retrieved. The end date is exclusive. For example, if end is 2019-03-29T13:05:00Z, the cost and usage data are retrieved from the start date up to, but not including, 2019-03-29T13:05:00Z.
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public DateTime? To { get; internal set; }

        /// <summary>
        /// Storage usage in GB per month.
        /// </summary>
        [JsonProperty(PropertyName = "storageUsage")]
        public double? StorageUsage { get; internal set; }

        /// <summary>
        /// Transfer usage in GB.
        /// </summary>
        [JsonProperty(PropertyName = "transferUsage")]
        public double? TransferUsage { get; internal set; }
    }
}
