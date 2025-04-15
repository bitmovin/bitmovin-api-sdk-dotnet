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
    /// CacheControl
    /// </summary>
    public class CacheControl
    {
        /// <summary>
        /// Cache control for storing data on CDN. Example \&quot;public, max-age&#x3D;0, no-cache\&quot;. Cache control is supported on S3, GCS and Azure output storage providers.
        /// </summary>
        [JsonProperty(PropertyName = "cacheControl")]
        public string _CacheControl { get; set; }
    }
}
