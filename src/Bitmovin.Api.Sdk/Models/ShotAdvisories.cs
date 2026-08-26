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
    /// The result of content advisory detection for a shot, covering both what was detected and whether the shot was assessed at all
    /// </summary>
    public class ShotAdvisories
    {
        /// <summary>
        /// Whether and how the shot was assessed for content advisories (required)
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public AdvisoryAnalysisStatus? Status { get; set; }

        /// <summary>
        /// The advisory-relevant imagery detected in this shot. Empty when the shot was assessed and nothing was found, or when it was not assessed at all (required)
        /// </summary>
        [JsonProperty(PropertyName = "advisories")]
        public List<ContentAdvisory> Advisories { get; set; } = new List<ContentAdvisory>();
    }
}
