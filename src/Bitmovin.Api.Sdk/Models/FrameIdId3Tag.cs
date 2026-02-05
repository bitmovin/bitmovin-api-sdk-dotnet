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
    /// FrameIdId3Tag
    /// </summary>
    public class FrameIdId3Tag : Id3Tag
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "FRAME_ID";
#pragma warning restore CS0414

        /// <summary>
        /// Base64 Encoded Data (required)
        /// </summary>
        [JsonProperty(PropertyName = "bytes")]
        public string Bytes { get; set; }

        /// <summary>
        /// 4 character long Frame ID (required)
        /// </summary>
        [JsonProperty(PropertyName = "frameId")]
        public string FrameId { get; set; }
    }
}
