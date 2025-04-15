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
    /// IABTaxonomy
    /// </summary>
    public class IABTaxonomy
    {
        /// <summary>
        /// Version
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// ContentTaxonomies
        /// </summary>
        [JsonProperty(PropertyName = "contentTaxonomies")]
        public List<string> ContentTaxonomies { get; set; } = new List<string>();

        /// <summary>
        /// AdOpportunityTaxonomies
        /// </summary>
        [JsonProperty(PropertyName = "adOpportunityTaxonomies")]
        public List<string> AdOpportunityTaxonomies { get; set; } = new List<string>();

        /// <summary>
        /// SensitiveTopicTaxonomies
        /// </summary>
        [JsonProperty(PropertyName = "sensitiveTopicTaxonomies")]
        public List<string> SensitiveTopicTaxonomies { get; set; } = new List<string>();
    }
}
