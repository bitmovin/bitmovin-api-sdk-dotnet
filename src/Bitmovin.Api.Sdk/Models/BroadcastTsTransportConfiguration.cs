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
        
        /// <summary>
        /// When false, the output stream is created at a constant bit rate. When true, the output rate is allowed to vary from a maximum rate set by the muxrate parameter down to the minimum required to carry the stream. Default: false
        /// </summary>
        [JsonProperty(PropertyName = "variableMuxRate")]
        public bool? VariableMuxRate { get; set; }
        
        /// <summary>
        /// Sets the presentation time stamp value for the first video frame. The timestamp is specified in the timescale of 90000. Default: 0
        /// </summary>
        [JsonProperty(PropertyName = "initialPresentationTimeStamp")]
        public double? InitialPresentationTimeStamp { get; set; }
        
        /// <summary>
        /// Sets the Program Clock Reference value at the beginning of the first packet for the transport stream. The PCR is specified in the timescale of 90000. Default: 0
        /// </summary>
        [JsonProperty(PropertyName = "initialProgramClockReference")]
        public double? InitialProgramClockReference { get; set; }
    }

}
