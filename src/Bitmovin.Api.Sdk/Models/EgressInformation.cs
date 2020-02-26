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
    /// EgressInformation
    /// </summary>
    public class EgressInformation
    {
        /// <summary>
        /// Category
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public EgressCategory? Category { get; set; }

        /// <summary>
        /// The number of bytes that have been transferred to the output (required)
        /// </summary>
        [JsonProperty(PropertyName = "bytes")]
        public long? Bytes { get; set; }

        /// <summary>
        /// OutputType
        /// </summary>
        [JsonProperty(PropertyName = "outputType")]
        public OutputType? OutputType { get; set; }

        /// <summary>
        /// OutputRegion
        /// </summary>
        [JsonProperty(PropertyName = "outputRegion")]
        public CloudRegion? OutputRegion { get; set; }
    }
}
