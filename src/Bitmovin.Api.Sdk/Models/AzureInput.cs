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
    /// AzureInput
    /// </summary>

    public class AzureInput : Input
    {
        /// <summary>
        /// Azure Account Name (required)
        /// </summary>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }
        
        /// <summary>
        /// Azure Account Key (required)
        /// </summary>
        [JsonProperty(PropertyName = "accountKey")]
        public string AccountKey { get; set; }
        
        /// <summary>
        /// Name of the bucket (required)
        /// </summary>
        [JsonProperty(PropertyName = "container")]
        public string Container { get; set; }
    }

}
