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
    /// SpekeDrm
    /// </summary>
    public class SpekeDrm : Drm
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "SPEKE";

        /// <summary>
        /// Unique Identifier of the content, will be generated if not set
        /// </summary>
        [JsonProperty(PropertyName = "contentId")]
        public string ContentId { get; set; }

        /// <summary>
        /// Optional key identifier, will be generated if not set. For SPEKE DRM Configurations with the same contentId and kid the key provider will provide the same keys. 
        /// </summary>
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }

        /// <summary>
        /// 16 byte initialization vector represented by a 32-character text string. It is mandatory if systemIds contains AES128 and FairPlay. 
        /// </summary>
        [JsonProperty(PropertyName = "iv")]
        public string Iv { get; set; }

        /// <summary>
        /// Key provider configuration for SPEKE (required)
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public SpekeDrmProvider Provider { get; set; }

        /// <summary>
        /// DRM system identifier of the content protection scheme. At minimum one is expected. Not all systemIds are currently supported, support depends on the muxing type.  Relates to SPEKE implementation. See https://dashif.org/identifiers/content_protection/ (required)
        /// </summary>
        [JsonProperty(PropertyName = "systemIds")]
        public List<string> SystemIds { get; set; } = new List<string>();
    }
}
