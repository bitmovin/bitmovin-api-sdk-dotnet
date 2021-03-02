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
    /// RescheduleEncodingRequest
    /// </summary>
    public class RescheduleEncodingRequest
    {
        /// <summary>
        /// Id of a custom infrastructure, e.g., AWS Cloud Connect
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureId")]
        public string InfrastructureId { get; set; }
    }
}
