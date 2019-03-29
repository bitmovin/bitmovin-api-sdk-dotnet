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
    /// CencPlayReady
    /// </summary>

    public class CencPlayReady
    {
        /// <summary>
        /// Url of the license server. Either the laUrl or the pssh needs to be provided.
        /// </summary>
        [JsonProperty(PropertyName = "laUrl")]
        public string LaUrl { get; set; }
        
        /// <summary>
        /// Base64 encoded pssh payload.
        /// </summary>
        [JsonProperty(PropertyName = "pssh")]
        public string Pssh { get; set; }
    }

}
