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
    /// LiveOptionsBreakdownEntry
    /// </summary>
    public class LiveOptionsBreakdownEntry
    {
        /// <summary>
        /// Date, format: yyyy-MM-dd (required)
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; internal set; }

        /// <summary>
        /// Hd
        /// </summary>
        [JsonProperty(PropertyName = "hd")]
        public LiveOptionsEntry Hd { get; set; }
    }
}
