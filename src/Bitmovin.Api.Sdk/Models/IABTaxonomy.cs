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
        /// Version of the IAB Content Taxonomy used for contentTaxonomies and sensitiveTopicTaxonomies.
        /// </summary>
        [JsonProperty(PropertyName = "contentVersion")]
        public string ContentVersion { get; set; }

        /// <summary>
        /// Version of the IAB Ad Product Taxonomy used for adOpportunityTaxonomies.
        /// </summary>
        [JsonProperty(PropertyName = "adProductVersion")]
        public string AdProductVersion { get; set; }

        /// <summary>
        /// IAB Content Taxonomy identifiers describing the scene&#39;s subject matter. Values are identifiers, not category names. (required)
        /// </summary>
        [JsonProperty(PropertyName = "contentTaxonomies")]
        public List<string> ContentTaxonomies { get; set; } = new List<string>();

        /// <summary>
        /// IAB Ad Product Taxonomy identifiers describing advertising categories relevant to this scene. Values are identifiers, not category names. (required)
        /// </summary>
        [JsonProperty(PropertyName = "adOpportunityTaxonomies")]
        public List<string> AdOpportunityTaxonomies { get; set; } = new List<string>();

        /// <summary>
        /// IAB Content Taxonomy identifiers for sensitive topics associated with this scene. Values are identifiers, not category names. (required)
        /// </summary>
        [JsonProperty(PropertyName = "sensitiveTopicTaxonomies")]
        public List<string> SensitiveTopicTaxonomies { get; set; } = new List<string>();
    }
}
