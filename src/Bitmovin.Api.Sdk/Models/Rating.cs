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
    /// An estimated content rating. Retains its original values in language-specific results.
    /// </summary>
    public class Rating
    {
        /// <summary>
        /// Region to which this estimated rating applies, such as US, UK or EU.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <summary>
        /// Name of the movie or television rating system used for this estimate.
        /// </summary>
        [JsonProperty(PropertyName = "system")]
        public string System { get; set; }

        /// <summary>
        /// AI-estimated rating label within the indicated system. Can be empty when no estimate is available.
        /// </summary>
        [JsonProperty(PropertyName = "rating")]
        public string _Rating { get; set; }
    }
}
