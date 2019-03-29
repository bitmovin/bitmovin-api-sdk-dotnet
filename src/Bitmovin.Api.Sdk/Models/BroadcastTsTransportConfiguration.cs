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
    /// BroadcastTsTransportConfiguration
    /// </summary>

    public class BroadcastTsTransportConfiguration
    {
        /// <summary>
        /// Output rate in bps. The value zero implies to use minimal rate. The minimal rate leaves approximately 15kbps of null packets in the stream.
        /// </summary>
        [JsonProperty(PropertyName = "muxrate")]
        public double? Muxrate { get; set; }
        
        /// <summary>
        /// Stop mux on errors. If true, implies halt multiplexing when any error is encountered. If false, errors are ignored and multiplexing continues. Note that the recovery from an error will usually result in an illegal transport stream and artifacts on a decoder.
        /// </summary>
        [JsonProperty(PropertyName = "stopOnError")]
        public bool? StopOnError { get; set; }
        
        /// <summary>
        /// If true, prevents adaptation fields with length field equal to zero in video, i.e., zero-length AF. Please note that this condition can only occur when pesAlign for the input stream is set to true.
        /// </summary>
        [JsonProperty(PropertyName = "preventEmptyAdaptionFieldsInVideo")]
        public bool? PreventEmptyAdaptionFieldsInVideo { get; set; }
        
        /// <summary>
        /// Program Association Table (PAT) repetition rate per second. Number of PATs per second.
        /// </summary>
        [JsonProperty(PropertyName = "patRepetitionRatePerSec")]
        public double? PatRepetitionRatePerSec { get; set; }
        
        /// <summary>
        /// Program Map Table (PMT) repetition rate per second. Number of PMTs for each program per second.
        /// </summary>
        [JsonProperty(PropertyName = "pmtRepetitionRatePerSec")]
        public double? PmtRepetitionRatePerSec { get; set; }
    }

}
