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
    /// DenoiseHqdn3dFilter
    /// </summary>
    public class DenoiseHqdn3dFilter : Filter
    {
        [JsonProperty(PropertyName = "type")]
#pragma warning disable CS0414
        private readonly string _type = "DENOISE_HQDN3D";
#pragma warning restore CS0414

        /// <summary>
        /// A non-negative floating point number which specifies spatial luma strength. It defaults to 4.0.
        /// </summary>
        [JsonProperty(PropertyName = "lumaSpatial")]
        public double? LumaSpatial { get; set; }

        /// <summary>
        /// A non-negative floating point number which specifies spatial chroma strength. It defaults to 3.0*luma_spatial/4.0.
        /// </summary>
        [JsonProperty(PropertyName = "chromaSpatial")]
        public double? ChromaSpatial { get; set; }

        /// <summary>
        /// A floating point number which specifies luma temporal strength. It defaults to 6.0*luma_spatial/4.0.
        /// </summary>
        [JsonProperty(PropertyName = "lumaTmp")]
        public double? LumaTmp { get; set; }

        /// <summary>
        /// A floating point number which specifies chroma temporal strength. It defaults to luma_tmp*chroma_spatial/luma_spatial.
        /// </summary>
        [JsonProperty(PropertyName = "chromaTmp")]
        public double? ChromaTmp { get; set; }
    }
}
