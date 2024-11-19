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
    /// LiveStandbyPoolEncodingManifest
    /// </summary>
    public class LiveStandbyPoolEncodingManifest
    {
        /// <summary>
        /// URL to the manifest
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; internal set; }

        /// <summary>
        /// ID of the manifest that was created for the encoding
        /// </summary>
        [JsonProperty(PropertyName = "manifestId")]
        public string ManifestId { get; internal set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public LiveStandbyPoolEncodingManifestType? Type { get; internal set; }
    }
}
