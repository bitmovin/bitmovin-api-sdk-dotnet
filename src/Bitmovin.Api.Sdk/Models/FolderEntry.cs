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
    /// FolderEntry
    /// </summary>

    public class FolderEntry
    {
        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FolderEntryType Type { get; set; }
        
        /// <summary>
        /// Path
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
    }

}
