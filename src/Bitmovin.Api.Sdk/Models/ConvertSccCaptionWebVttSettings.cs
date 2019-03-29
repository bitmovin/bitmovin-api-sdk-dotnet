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
    /// ConvertSccCaptionWebVttSettings
    /// </summary>

    public class ConvertSccCaptionWebVttSettings
    {
        /// <summary>
        /// PositionMode
        /// </summary>
        [JsonProperty(PropertyName = "positionMode")]
        public ConvertSccPositionMode PositionMode { get; set; }
        
        /// <summary>
        /// Remove flash (blinking) information when converting SCC to WebVTT
        /// </summary>
        [JsonProperty(PropertyName = "removeFlash")]
        public bool? RemoveFlash { get; set; }
        
        /// <summary>
        /// Remove color information when converting SCC to WebVTT
        /// </summary>
        [JsonProperty(PropertyName = "removeColor")]
        public bool? RemoveColor { get; set; }
    }

}
