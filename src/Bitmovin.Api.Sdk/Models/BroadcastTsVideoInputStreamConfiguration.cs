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
    /// BroadcastTsVideoInputStreamConfiguration
    /// </summary>

    public class BroadcastTsVideoInputStreamConfiguration : BroadcastTsInputStreamConfiguration
    {
        /// <summary>
        /// If true, add access unit delimiters (AUD) to AVC stream if AUD is missing from input elementary stream.
        /// </summary>
        [JsonProperty(PropertyName = "insertAccessUnitDelimiterInAvc")]
        public bool? InsertAccessUnitDelimiterInAvc { get; set; }
        
        /// <summary>
        /// Maximum Decoder Delay in 90 KHz cycles. When non-zero, the difference between the PCR and the DTS for each picture as it is inserted into the output transport stream is limited to this number of 90 KHz cycles. Values below 1000 are treated as 0 and ignored. Valid Range [0, 1000-900000]
        /// </summary>
        [JsonProperty(PropertyName = "maxDecodeDelay")]
        public int? MaxDecodeDelay { get; set; }
    }

}
