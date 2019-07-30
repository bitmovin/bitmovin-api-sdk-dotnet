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
    /// InsertableContentInput
    /// </summary>

    public class InsertableContentInput
    {
        /// <summary>
        /// Id of the input hosting the video file (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }
        
        /// <summary>
        /// Path to the file on the input (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputPath")]
        public string InputPath { get; set; }
        
        /// <summary>
        /// Description of this input
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

}
