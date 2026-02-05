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
    /// DolbyAtmosPreprocessing
    /// </summary>
    public class DolbyAtmosPreprocessing
    {
        /// <summary>
        /// It indicates a gain change to be applied in the Dolby Atmos decoder in order to implement dynamic range compression.  The values typically indicate gain reductions (cut) during loud passages and gain increases (boost) during quiet passages based on desired compression characteristics. 
        /// </summary>
        [JsonProperty(PropertyName = "dynamicRangeCompression")]
        public DolbyAtmosDynamicRangeCompression DynamicRangeCompression { get; set; }
    }
}
