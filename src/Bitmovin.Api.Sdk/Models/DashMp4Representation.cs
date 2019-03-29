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
    /// DashMp4Representation
    /// </summary>

    public class DashMp4Representation : DashRepresentation
    {
        /// <summary>
        /// Path to the MP4 file
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; set; }
    }

}
