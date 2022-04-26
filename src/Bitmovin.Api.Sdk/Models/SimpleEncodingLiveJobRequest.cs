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
    /// SimpleEncodingLiveJobRequest
    /// </summary>
    public class SimpleEncodingLiveJobRequest
    {
        /// <summary>
        /// Input
        /// </summary>
        [JsonProperty(PropertyName = "input")]
        public SimpleEncodingLiveJobInput Input { get; set; }

        /// <summary>
        /// Please take a look at the [documentation](https://bitmovin.com/docs/encoding/articles/simple-encoding-api-live#outputs) (required)
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public List<SimpleEncodingLiveJobOutput> Outputs { get; set; } = new List<SimpleEncodingLiveJobOutput>();

        /// <summary>
        /// The cloud region that will be used for the live encoding. This value has to be set.
        /// </summary>
        [JsonProperty(PropertyName = "cloudRegion")]
        public SimpleEncodingLiveCloudRegion? CloudRegion { get; set; }

        /// <summary>
        /// This property will be used for naming the encoding.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
