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
    /// TimecodeTrackTrimmingInputStream
    /// </summary>

    public class TimecodeTrackTrimmingInputStream : InputStream
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "TRIMMING_TIME_CODE_TRACK";

        /// <summary>
        /// The id of the ingest input stream that should be trimmed
        /// </summary>
        [JsonProperty(PropertyName = "inputStreamId")]
        public string InputStreamId { get; set; }
        
        /// <summary>
        /// Defines the timecode, in SMPTE-12M format, of the frame from which the encoding should start. The frame indicated by this value will be included in the encoding
        /// </summary>
        [JsonProperty(PropertyName = "startTimeCode")]
        public string StartTimeCode { get; set; }
        
        /// <summary>
        /// Defines the timecode, in SMPTE-12M format, of the frame at which the encoding should stop. The frame indicated by this value will be included in the encoding
        /// </summary>
        [JsonProperty(PropertyName = "endTimeCode")]
        public string EndTimeCode { get; set; }
    }

}
