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
    /// FileInputStream
    /// </summary>

    public class FileInputStream : InputStream
    {
        /// <summary>
        /// Id of input (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputId")]
        public string InputId { get; set; }
        
        /// <summary>
        /// Path to file (required)
        /// </summary>
        [JsonProperty(PropertyName = "inputPath")]
        public string InputPath { get; set; }
        
        /// <summary>
        /// FileType
        /// </summary>
        [JsonProperty(PropertyName = "fileType")]
        public FileInputStreamType? FileType { get; set; }
    }

}
