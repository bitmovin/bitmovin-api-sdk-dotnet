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
    /// PerTitle
    /// </summary>
    public class PerTitle
    {
        /// <summary>
        /// Per-Title configuration for H264
        /// </summary>
        [JsonProperty(PropertyName = "h264Configuration")]
        public H264PerTitleConfiguration H264Configuration { get; set; }

        /// <summary>
        /// Per-Title configuration for H265
        /// </summary>
        [JsonProperty(PropertyName = "h265Configuration")]
        public H265PerTitleConfiguration H265Configuration { get; set; }

        /// <summary>
        /// Per-Title configuration for VP9
        /// </summary>
        [JsonProperty(PropertyName = "vp9Configuration")]
        public Vp9PerTitleConfiguration Vp9Configuration { get; set; }
    }
}
