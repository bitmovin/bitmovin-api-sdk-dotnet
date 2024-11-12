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
    /// EncodingTemplateDetails
    /// </summary>
    public class EncodingTemplateDetails : EncodingTemplateResponse
    {
        /// <summary>
        /// The url to download the template file (required)
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; internal set; }
    }
}
