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
    /// WebVttExtract
    /// </summary>

    public class WebVttExtract : BitmovinResource
    {
        /// <summary>
        /// The input stream to extract the subtitle from
        /// </summary>
        [JsonProperty(PropertyName = "inputStream")]
        public InputStream InputStream { get; set; }
        
        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; set; }
        
        /// <summary>
        /// Name of the captions file
        /// </summary>
        [JsonProperty(PropertyName = "fileName")]
        public string FileName { get; set; }
    }

}
