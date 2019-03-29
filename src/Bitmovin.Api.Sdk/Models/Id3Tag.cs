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
    /// Id3Tag
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(RawId3Tag), "RAW")]
    [JsonSubtypes.KnownSubType(typeof(FrameIdId3Tag), "FRAME_ID")]
    [JsonSubtypes.KnownSubType(typeof(PlaintextId3Tag), "PLAIN_TEXT")]

    public class Id3Tag : BitmovinResource
    {
        /// <summary>
        /// PositionMode
        /// </summary>
        [JsonProperty(PropertyName = "positionMode")]
        public Id3TagPositionMode PositionMode { get; set; }
        
        /// <summary>
        /// Frame number at which the Tag should be inserted
        /// </summary>
        [JsonProperty(PropertyName = "frame")]
        public long? Frame { get; set; }
        
        /// <summary>
        /// Time in seconds where the Tag should be inserted
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public double? Time { get; set; }
    }

}
