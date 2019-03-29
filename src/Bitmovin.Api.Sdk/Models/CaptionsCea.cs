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
    /// CaptionsCea
    /// </summary>

    public class CaptionsCea : BitmovinResource
    {
        /// <summary>
        /// Select the channel for the caption information
        /// </summary>
        [JsonProperty(PropertyName = "channel")]
        public int? Channel { get; set; }
        
        /// <summary>
        /// The input stream to extract the subtitle from
        /// </summary>
        [JsonProperty(PropertyName = "inputStream")]
        public InputStream InputStream { get; set; }
        
        /// <summary>
        /// OutputFormat
        /// </summary>
        [JsonProperty(PropertyName = "outputFormat")]
        public OutputFormat OutputFormat { get; set; }
        
        /// <summary>
        /// Name of the captions file
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }
        
        /// <summary>
        /// Outputs
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<EncodingOutput> Outputs { get; set; }
    }

}
