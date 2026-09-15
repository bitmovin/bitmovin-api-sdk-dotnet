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
    /// Av1PerTitleConfiguration
    /// </summary>
    public class Av1PerTitleConfiguration : PerTitleConfiguration
    {
        /// <summary>
        /// Desired target quality of the highest representation expressed as a CRF value. If not set, it is derived from the content, starting from 34 for SDR content of at most FullHD and at most 30 fps; HFR (more than 30 fps) reduces it by 2; a resolution above FullHD reduces it by 2; HDR10 or HLG reduces it by 2; and Dolby Vision reduces it by 4 instead of the HDR10 reduction. These reductions are cumulative, so the lowest derived value is 26, for Dolby Vision 4K at 60 fps.
        /// </summary>
        [JsonProperty(PropertyName = "targetQualityCrf")]
        public double? TargetQualityCrf { get; set; }
    }
}
