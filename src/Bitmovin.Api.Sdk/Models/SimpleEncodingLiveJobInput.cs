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
    /// SimpleEncodingLiveJobInput
    /// </summary>
    public class SimpleEncodingLiveJobInput
    {
        /// <summary>
        /// Defines which protocol is being used as input of the live stream. 
        /// </summary>
        [JsonProperty(PropertyName = "inputType")]
        public SimpleEncodingLiveJobInputType? InputType { get; set; }

        /// <summary>
        /// The aspect ratio of the input video stream
        /// </summary>
        [JsonProperty(PropertyName = "inputAspectRatio")]
        public SimpleEncodingLiveInputAspectRatio? InputAspectRatio { get; set; }
    }
}
