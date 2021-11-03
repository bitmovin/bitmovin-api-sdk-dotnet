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
    /// Either height or width is required. It is also possible to set both properties.
    /// </summary>
    public class Bif : BitmovinResource
    {
        /// <summary>
        /// Height of one thumbnail
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// Width of one thumbnail. Roku recommends a width of 240 for SD and 320 for HD.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// Distance in seconds between a screenshot (required)
        /// </summary>
        [JsonProperty(PropertyName = "distance")]
        public double? Distance { get; set; }

        /// <summary>
        /// Filename of the Bif image. (required)
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; set; } = new List<EncodingOutput>();

        /// <summary>
        /// Specifies the aspect mode that is used when both height and width are specified Only supported starting with encoder version &#x60;2.85.0&#x60;. 
        /// </summary>
        [JsonProperty(PropertyName = "aspectMode")]
        public ThumbnailAspectMode? AspectMode { get; set; }
    }
}
