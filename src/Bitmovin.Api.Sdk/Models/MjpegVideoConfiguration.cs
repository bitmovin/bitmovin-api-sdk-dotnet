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
    /// MjpegVideoConfiguration
    /// </summary>

    public class MjpegVideoConfiguration : CodecConfiguration
    {
        /// <summary>
        /// Width of the encoded video
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }
        
        /// <summary>
        /// Height of the encoded video
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }
        
        /// <summary>
        /// Target frame rate of the encoded video!
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public double? Rate { get; set; }
        
        /// <summary>
        /// The quality scale parameter
        /// </summary>
        [JsonProperty(PropertyName = "qScale")]
        public int? QScale { get; set; }
        
        /// <summary>
        /// PixelFormat
        /// </summary>
        [JsonProperty(PropertyName = "pixelFormat")]
        public PixelFormat PixelFormat { get; set; }
    }

}
