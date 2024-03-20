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
    /// StreamsDomainRestrictionCreateRequest
    /// </summary>
    public class StreamsDomainRestrictionCreateRequest
    {
        /// <summary>
        /// The list of allowed domains (required)
        /// </summary>
        [JsonProperty(PropertyName = "allowedDomains")]
        public List<string> AllowedDomains { get; set; } = new List<string>();

        /// <summary>
        /// Controls if requests to domain restricted streams without referer header should be allowed or denied
        /// </summary>
        [JsonProperty(PropertyName = "allowNoReferer")]
        public bool? AllowNoReferer { get; set; }

        /// <summary>
        /// Controls if Stream is accessible via sharing URL or not
        /// </summary>
        [JsonProperty(PropertyName = "allowShare")]
        public bool? AllowShare { get; set; }
    }
}
