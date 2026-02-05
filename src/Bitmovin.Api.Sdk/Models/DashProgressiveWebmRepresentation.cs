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
    /// DashProgressiveWebmRepresentation
    /// </summary>
    public class DashProgressiveWebmRepresentation : DashMuxingRepresentation
    {
        [JsonProperty(PropertyName = "typeDiscriminator")]
#pragma warning disable CS0414
        private readonly string _typeDiscriminator = "PROGRESSIVE_WEBM";
#pragma warning restore CS0414

        /// <summary>
        /// Path to the Progressive WebM file (required)
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; set; }
    }
}
