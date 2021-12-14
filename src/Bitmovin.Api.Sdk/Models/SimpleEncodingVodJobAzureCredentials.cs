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
    /// SimpleEncodingVodJobAzureCredentials
    /// </summary>
    public class SimpleEncodingVodJobAzureCredentials : SimpleEncodingVodJobCredentials
    {
        /// <summary>
        /// Azure Account Key used for authentication (required)
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
    }
}
