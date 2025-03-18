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
    /// CacheControlSettingsHls
    /// </summary>
    public class CacheControlSettingsHls
    {
        /// <summary>
        /// Cache control settings for HLS Multivariant playlist.
        /// </summary>
        [JsonProperty(PropertyName = "multiVariantPlaylist")]
        public CacheControl MultiVariantPlaylist { get; set; }

        /// <summary>
        /// Cache control settings for HLS Media playlist.
        /// </summary>
        [JsonProperty(PropertyName = "variantPlaylist")]
        public CacheControl VariantPlaylist { get; set; }
    }
}
