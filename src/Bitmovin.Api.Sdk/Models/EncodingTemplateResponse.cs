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
    /// EncodingTemplateResponse
    /// </summary>
    public class EncodingTemplateResponse : BitmovinResource
    {
        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public EncodingTemplateType? Type { get; set; }
    }
}
