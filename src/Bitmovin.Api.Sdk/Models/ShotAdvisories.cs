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
    /// Advisory assessment for a shot.
    /// </summary>
    public class ShotAdvisories
    {
        /// <summary>
        /// Outcome of the advisory assessment for this shot. (required)
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public AdvisoryAnalysisStatus? Status { get; set; }

        /// <summary>
        /// Advisories reported for this shot. Consult status before interpreting an empty or omitted list. (required)
        /// </summary>
        [JsonProperty(PropertyName = "advisories")]
        public List<ContentAdvisory> Advisories { get; set; } = new List<ContentAdvisory>();
    }
}
