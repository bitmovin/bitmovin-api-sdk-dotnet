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
    /// DashMp4DrmRepresentation
    /// </summary>
    public class DashMp4DrmRepresentation : DashMp4Representation
    {
        [JsonProperty(PropertyName = "typeDiscriminator")]
#pragma warning disable CS0414
        private readonly string _typeDiscriminator = "DRM_MP4";
#pragma warning restore CS0414

        /// <summary>
        /// DRM Id (required)
        /// </summary>
        [JsonProperty(PropertyName = "drmId")]
        public string DrmId { get; set; }
    }
}
