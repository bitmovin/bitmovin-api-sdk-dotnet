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
    /// AzureSpeechServicesCredentials
    /// </summary>
    public class AzureSpeechServicesCredentials
    {
        /// <summary>
        /// Azure Speech Services resource key (required)
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionKey")]
        public string SubscriptionKey { get; set; }
    }
}
