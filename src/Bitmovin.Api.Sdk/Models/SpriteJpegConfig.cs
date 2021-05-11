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
    /// SpriteJpegConfig
    /// </summary>
    public class SpriteJpegConfig
    {
        /// <summary>
        /// Quality of the JPEG file in percent. Allowed values 20 - 100 (required)
        /// </summary>
        [JsonProperty(PropertyName = "quality")]
        public int? Quality { get; set; }
    }
}
