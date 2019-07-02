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
    /// CencWidevine
    /// </summary>

    public class CencWidevine
    {
        /// <summary>
        /// Base64 encoded pssh payload (required)
        /// </summary>
        [JsonProperty(PropertyName = "pssh")]
        public string Pssh { get; set; }
    }

}
