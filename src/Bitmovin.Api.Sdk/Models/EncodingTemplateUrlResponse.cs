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
    /// EncodingTemplateUrlResponse
    /// </summary>
    public class EncodingTemplateUrlResponse
    {
        /// <summary>
        /// The download URL of the encoding template. (required)
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; internal set; }
    }
}
