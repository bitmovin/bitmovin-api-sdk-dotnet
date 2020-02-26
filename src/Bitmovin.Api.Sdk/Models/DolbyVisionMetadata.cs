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
    /// DolbyVisionMetadata
    /// </summary>
    public class DolbyVisionMetadata : BitmovinResource
    {
        /// <summary>
        /// Dolby Vision Profile (required)
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public DolbyVisionProfile? Profile { get; set; }

        /// <summary>
        /// Dolby Vision Metadata Source (required)
        /// </summary>
        [JsonProperty(PropertyName = "metadataSource")]
        public DolbyVisionMetadataSource? MetadataSource { get; set; }

        /// <summary>
        /// ID of the Dolby Vision Metadata Ingest Input Stream which provides the XML Metadata file. Required if metadataSource is set to INPUT_STREAM.
        /// </summary>
        [JsonProperty(PropertyName = "metadataInputStreamId")]
        public string MetadataInputStreamId { get; set; }
    }
}
