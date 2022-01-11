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
    /// DashRepresentationTypeResponse
    /// </summary>
    public class DashRepresentationTypeResponse
    {
        /// <summary>
        /// The type of the DASH representation
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public DashRepresentationTypeDiscriminator? Type { get; set; }
    }
}
