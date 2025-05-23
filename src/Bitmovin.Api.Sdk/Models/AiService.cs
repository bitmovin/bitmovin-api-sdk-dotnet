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
    /// AiService
    /// </summary>
    public class AiService
    {
        /// <summary>
        /// AI service provider
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public AiServiceProvider? Provider { get; set; }
    }
}
