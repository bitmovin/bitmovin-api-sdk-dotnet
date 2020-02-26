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
    /// DefaultDashManifestPeriod
    /// </summary>
    public class DefaultDashManifestPeriod
    {
        /// <summary>
        /// List the encoding ids for which the conditions should apply
        /// </summary>
        [JsonProperty(PropertyName = "encodingIds")]
        public List<string> EncodingIds { get; set; } = new List<string>();

        /// <summary>
        /// Adds an adaption set for every item to the period
        /// </summary>
        [JsonProperty(PropertyName = "adaptationSets")]
        public List<DefaultManifestCondition> AdaptationSets { get; set; } = new List<DefaultManifestCondition>();
    }
}
