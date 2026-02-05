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
    /// DeinterlaceFilter
    /// </summary>
    public class DeinterlaceFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "DEINTERLACE";
#pragma warning restore CS0414

        /// <summary>
        /// Parity
        /// </summary>
        [JsonProperty(PropertyName = "parity")]
        public PictureFieldParity? Parity { get; set; }

        /// <summary>
        /// Mode
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public DeinterlaceMode? Mode { get; set; }

        /// <summary>
        /// FrameSelectionMode
        /// </summary>
        [JsonProperty(PropertyName = "frameSelectionMode")]
        public DeinterlaceFrameSelectionMode? FrameSelectionMode { get; set; }

        /// <summary>
        /// AutoEnable
        /// </summary>
        [JsonProperty(PropertyName = "autoEnable")]
        public DeinterlaceAutoEnable? AutoEnable { get; set; }
    }
}
