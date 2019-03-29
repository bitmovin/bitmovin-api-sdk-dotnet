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
    /// Encoding
    /// </summary>

    public class Encoding : BitmovinResource
    {
        /// <summary>
        /// CloudRegion
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public CloudRegion CloudRegion { get; set; }
        
        /// <summary>
        /// Version of the encoder
        /// </summary>
        [JsonProperty(PropertyName = "encoderVersion")]
        public string EncoderVersion { get; set; }
        
        /// <summary>
        /// Define an external infrastructure to run the encoding on. Note If you set this value, the &#x60;cloudRegion&#x60; must be &#39;EXTERNAL&#39;.
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureId")]
        public string InfrastructureId { get; set; }
        
        /// <summary>
        /// Infrastructure
        /// </summary>
        [JsonProperty(PropertyName = "infrastructure")]
        public InfrastructureSettings Infrastructure { get; set; }
        
        /// <summary>
        /// You may pass a list of groups associated with this encoding. This will enable you to group results in the statistics resource
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public List<string> Labels { get; set; }
    }

}
