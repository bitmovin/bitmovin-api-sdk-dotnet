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
    /// EncodingOutput
    /// </summary>
    public class EncodingOutput
    {
        /// <summary>
        /// Id of the corresponding output (required)
        /// </summary>
        [JsonProperty(PropertyName = "outputId")]
        public string OutputId { get; set; }

        /// <summary>
        /// Subdirectory where to save the files to (required)
        /// </summary>
        [JsonProperty(PropertyName = "outputPath")]
        public string OutputPath { get; set; }

        /// <summary>
        /// Acl
        /// </summary>
        [JsonProperty(PropertyName = "acl")]
        public List<AclEntry> Acl { get; set; } = new List<AclEntry>();
    }
}
