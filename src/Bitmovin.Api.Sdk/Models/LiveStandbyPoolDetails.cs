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
    /// LiveStandbyPoolDetails
    /// </summary>
    public class LiveStandbyPoolDetails : LiveStandbyPoolResponse
    {
        /// <summary>
        /// Base64 encoded template used to start the encodings in the pool
        /// </summary>
        [JsonProperty(PropertyName = "encodingTemplate")]
        public string EncodingTemplate { get; internal set; }
    }
}
