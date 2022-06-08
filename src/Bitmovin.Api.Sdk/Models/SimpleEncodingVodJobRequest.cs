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
    /// SimpleEncodingVodJobRequest
    /// </summary>
    public class SimpleEncodingVodJobRequest
    {
        /// <summary>
        /// The template that will be used for the encoding.
        /// </summary>
        [JsonProperty(PropertyName = "encodingTemplate")]
        public EncodingTemplate? EncodingTemplate { get; set; }

        /// <summary>
        /// Inputs
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public List<SimpleEncodingVodJobInput> Inputs { get; set; } = new List<SimpleEncodingVodJobInput>();

        /// <summary>
        /// Please take a look at the [documentation](https://bitmovin.com/docs/encoding/articles/simple-encoding-api#inputs-outputs) (required)
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<SimpleEncodingVodJobOutput> Outputs { get; set; } = new List<SimpleEncodingVodJobOutput>();

        /// <summary>
        /// This property will be used for naming the encoding and the manifests.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
