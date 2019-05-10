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
    /// H264PictureTimingTrimmingInputStream
    /// </summary>

    public class H264PictureTimingTrimmingInputStream : InputStream
    {
        /// <summary>
        /// The id of the ingest input stream that should be trimmed
        /// </summary>
        [JsonProperty(PropertyName = "inputStreamId")]
        public string InputStreamId { get; set; }
        
        /// <summary>
        /// Defines the H264 SEI picture timing, as specified in ISO/IEC 14496-10:2008, of the frame from which the encoding should start. The frame indicated by this value will be included in the encoding
        /// </summary>
        [JsonProperty(PropertyName = "startPicTiming")]
        public string StartPicTiming { get; set; }
        
        /// <summary>
        /// Defines the H264 SEI picture timing, as specified in ISO/IEC 14496-10:2008, of the frame at which the encoding should stop. The frame indicated by this value will be included in the encoding
        /// </summary>
        [JsonProperty(PropertyName = "endPicTiming")]
        public string EndPicTiming { get; set; }
    }

}
