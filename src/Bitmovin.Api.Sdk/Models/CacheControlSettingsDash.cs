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
    /// CacheControlSettingsDash
    /// </summary>
    public class CacheControlSettingsDash
    {
        /// <summary>
        /// Cache control settings for DASH Timeline manifest.
        /// </summary>
        [JsonProperty(PropertyName = "timelineManifest")]
        public CacheControl TimelineManifest { get; set; }

        /// <summary>
        /// Cache control settings for DASH Template manifest.
        /// </summary>
        [JsonProperty(PropertyName = "templateManifest")]
        public CacheControl TemplateManifest { get; set; }
    }
}
