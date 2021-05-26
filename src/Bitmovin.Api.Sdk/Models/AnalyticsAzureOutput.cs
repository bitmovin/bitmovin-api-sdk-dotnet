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
    /// AnalyticsAzureOutput
    /// </summary>
    public class AnalyticsAzureOutput : AnalyticsOutput
    {
        [JsonProperty(PropertyName = "type")]
        private readonly string _type = "AZURE";

        /// <summary>
        /// Azure Account Name (required)
        /// </summary>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Microsoft Azure Account Access Key with the &#x60;Contributor Role&#x60; (required)
        /// </summary>
        [JsonProperty(PropertyName = "accountKey")]
        public string AccountKey { get; set; }

        /// <summary>
        /// Microsoft Azure container name (required)
        /// </summary>
        [JsonProperty(PropertyName = "container")]
        public string Container { get; set; }
    }
}
