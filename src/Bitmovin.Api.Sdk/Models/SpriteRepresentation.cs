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
    /// SpriteRepresentation
    /// </summary>
    public class SpriteRepresentation : DashRepresentation
    {
        [JsonProperty(PropertyName = "typeDiscriminator")]
        private readonly string _typeDiscriminator = "SPRITE";

        /// <summary>
        /// UUID of an encoding (required)
        /// </summary>
        [JsonProperty(PropertyName = "encodingId")]
        public string EncodingId { get; set; }

        /// <summary>
        /// UUID of a stream (required)
        /// </summary>
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }

        /// <summary>
        /// UUID of a Sprite (required)
        /// </summary>
        [JsonProperty(PropertyName = "spriteId")]
        public string SpriteId { get; set; }

        /// <summary>
        /// Path to sprite segments. Will be used as the representation id in the manifest. (required)
        /// </summary>
        [JsonProperty(PropertyName = "segmentPath")]
        public string SegmentPath { get; set; }
    }
}
