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
    /// TsMuxingConfiguration
    /// </summary>
    public class TsMuxingConfiguration
    {
        /// <summary>
        /// An integer value. Value for program_number field in the MPEG Transport Stream Program Map Table (PMT). The value zero is reserved for the NIT PID entry in the PAT.
        /// </summary>
        [JsonProperty(PropertyName = "programNumber")]
        public int? ProgramNumber { get; set; }

        /// <summary>
        /// Pmt
        /// </summary>
        [JsonProperty(PropertyName = "pmt")]
        public TsProgramMapTableConfiguration Pmt { get; set; }

        /// <summary>
        /// Pcr
        /// </summary>
        [JsonProperty(PropertyName = "pcr")]
        public TsProgramClockReferenceConfiguration Pcr { get; set; }

        /// <summary>
        /// VideoStreams
        /// </summary>
        [JsonProperty(PropertyName = "videoStreams")]
        public List<TsVideoStreamConfiguration> VideoStreams { get; set; } = new List<TsVideoStreamConfiguration>();

        /// <summary>
        /// AudioStreams
        /// </summary>
        [JsonProperty(PropertyName = "audioStreams")]
        public List<TsAudioStreamConfiguration> AudioStreams { get; set; } = new List<TsAudioStreamConfiguration>();
    }
}
